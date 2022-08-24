using System;
using EasyModbus;
namespace APIs.models;

public class MODBUSClient : Client
{
	ModbusClient client;

	public MODBUSClient(string url) : base(url)
	{
		int port = 502;
		client = new ModbusClient(url, port);
		client.Connect();
	}

	public int ReadValue(Data data)
    {
		int[] vals = client.ReadHoldingRegisters(data.address, 1);
		return vals[0];
    }

	public override string TestConnection()
    {
		int[] outputs = client.ReadInputRegisters(12, 1);
		int input = 10;
		client.WriteSingleRegister(12, input);
		return outputs[0].ToString();
    }

	~MODBUSClient()
    {
		client.Disconnect();
    }
}

public class ModbusTCPMachine1 : Server
{
	private MODBUSClient client;
	TearTapeMachine machine;

	public ModbusTCPMachine1(string url, string name)
    {
		client = new MODBUSClient(url);
		machine = new TearTapeMachine(name);
    }

    public override void ReadData()
    {
		machine.tapeData.ch_tape_alignment_enable_dpr.val = client.ReadValue(machine.tapeData.ch_tape_alignment_enable_dpr);
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

public class ModbusTCPMachine2 : Server
{
	private MODBUSClient client;
	PacketEntryMachine machine;

	public ModbusTCPMachine2(string url, string name)
    {
		client = new MODBUSClient(url);
		machine = new PacketEntryMachine(name);
    }

    public override void ReadData()
    {
		machine.packetEntryData.ch_entry_double_pack_ipr.val = client.ReadValue(machine.packetEntryData.ch_entry_double_pack_ipr);
		machine.packetEntryData.ch_entry_pack_on_conveyor_ipr.val = client.ReadValue(machine.packetEntryData.ch_entry_pack_on_conveyor_ipr);
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
