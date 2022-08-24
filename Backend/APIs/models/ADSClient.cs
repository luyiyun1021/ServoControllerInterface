using System;
using TwinCAT.Ads;
namespace APIs.models;

//public GeneralData gServer;
//public TearTapeData tServer;
//public MotorizationData mServer;
//public PacketEntryData peServer;
//public PacketWrapData pwServer;
//public FilmData fServer;
public class ADSClient : Client
{
    AdsClient client = new AdsClient();
    public ADSClient(string url) : base(url)
	{
        client.Connect(851);
	}

    public T ReadValue<T>(Data data)
    {
        var tagName = string.Format("MAIN.{0}", data.name);
        var handler = client.CreateVariableHandle(tagName);
        var val = client.ReadAny(handler, typeof(T));
        return (T)val;
    }

    ~ADSClient()
    {
        client.Disconnect();
    }
    
}

public class ADSMachine1 : Server
{
    ADSClient client;
    GeneralMachine machine;

    public ADSMachine1(string url, string name)
    {
        client = new ADSClient(url);
        machine = new GeneralMachine(name);
    }

    public void ReadChGpChChecksDisableSdp() // mock response here
    {
        machine.generalData.ch_gp_ch_checks_disable_sdp.val = 
            client.ReadValue<bool>(machine.generalData.ch_gp_ch_checks_disable_sdp);
    }

    public void ReadChGpCtNoProductionCnt() // mock response here
    {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        machine.generalData.ch_gp_ct_no_production_cnt.val = 
            client.ReadValue<Int16>(machine.generalData.ch_gp_ct_no_production_cnt);
    }

    public override void ReadData()
    {
        ReadChGpChChecksDisableSdp();
        ReadChGpCtNoProductionCnt();
    }

    public void TestConnection()
    {

    }

    public override List<ErrorMessage> ReportErrors()
    {
        return machine.ReportErrors();
    }
}

public class ADSMachine2 : Server
{
    ADSClient client;
    MotorizationMachine machine;

    public ADSMachine2(string url, string name)
    {
        client = new ADSClient(url);
        machine = new MotorizationMachine(name);
    }

    public void ReadChMotorStackLevelErrorCounterCnt()
    {
        machine.motorizationData.ch_motor_stack_level_error_counter_cnt.val = 
            client.ReadValue<Int16>(machine.motorizationData.ch_motor_stack_level_error_counter_cnt);
    }

    public void ReadChMotorSlowPhaseIfl()
    {
        machine.motorizationData.ch_motor_slow_phase_ifl.val = 
            client.ReadValue<Int16>(machine.motorizationData.ch_motor_slow_phase_ifl);
    }

    public override void ReadData()
    {
        ReadChMotorSlowPhaseIfl();
        ReadChMotorStackLevelErrorCounterCnt();
    }

    public void TestConnection()
    {

    }

    public override List<ErrorMessage> ReportErrors()
    {
        return machine.ReportErrors();
    }
}