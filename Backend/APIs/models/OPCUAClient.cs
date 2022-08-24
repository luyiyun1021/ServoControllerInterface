using System;
using Opc.UaFx;
using Opc.UaFx.Client;
namespace APIs.models;

public class OPCUAClient : Client
{
    OpcClient client;

	public OPCUAClient(string url): base(url)
	{
        client = new OpcClient(url);
        client.Connect();
	}

    public T ReadValue<T>(Data data)
    {
        var tagName = string.Format("ns=2;s=Tag{0}", data.address);
        OpcValue val = client.ReadNode(tagName);
        return val.As<T>();
    }

	public override string TestConnection()
    {
        var tagName = "ns=2;s=Tag7";

        double temperature = Convert.ToDouble(22);
        client.WriteNode(tagName, temperature);

        OpcValue retVal = client.ReadNode(tagName);
        string val = retVal.ToString();

        return val;
    }

    ~OPCUAClient()
    {
        client.Disconnect();    
    }
}

public class OPCUAMachine1 : Server
{
    // define variables in the machine and functions for judging if a certain parameter is abnormal

    OPCUAClient client;
    PacketWrapMachine machine;

    public OPCUAMachine1(string url, string name)
    {
        client = new OPCUAClient(url);
        machine = new PacketWrapMachine(name);
    }

    public override void ReadData()
    {
        // update all data
        machine.packetWrapData.ch_wl_film_position_check_enable_ipr.val = client.ReadValue<int>(machine.packetWrapData.ch_wl_film_position_check_enable_ipr);
    }

    public override List<ErrorMessage> ReportErrors()
    {
        return machine.ReportErrors();
    }

    public string TestConnection()
    {
        return client.TestConnection();
    }

}

public class OPCUAMachine2 : Server
{
    private OPCUAClient client;
    FilmMachine machine;

    public OPCUAMachine2(string url, string name)
    {
        client = new OPCUAClient(url);
        machine = new FilmMachine(name);
    }

    public override void ReadData()
    {
        machine.filmData.ch_film_left_reel_unwinding_dfl.val = client.ReadValue<bool>(machine.filmData.ch_film_left_reel_unwinding_dfl);
        machine.filmData.ch_film_right_reel_unwinding_dfl.val = client.ReadValue<bool>(machine.filmData.ch_film_right_reel_unwinding_dfl);
        machine.filmData.ch_film_reel_counter_cnt_m.val = client.ReadValue<int>(machine.filmData.ch_film_reel_counter_cnt_m);
        machine.filmData.ch_film_reject_aut_film_splice_cnt_r.val = client.ReadValue<int>(machine.filmData.ch_film_reject_aut_film_splice_cnt_r);
        machine.filmData.ch_film_reject_film_splice_cnt_r.val = client.ReadValue<int>(machine.filmData.ch_film_reject_film_splice_cnt_r);
    }

    public override List<ErrorMessage> ReportErrors()
    {
        return machine.ReportErrors();
    }
}

