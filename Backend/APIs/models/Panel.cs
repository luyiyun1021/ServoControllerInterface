using System;
using Opc.UaFx.Client;
namespace APIs.models;
public class ErrorMessage
{
    public string name { get; set; }

    public string sensorNo { get; set; }

    public string time { get; set; }

    public string objectType { get; set; }

    public int address { get; set; }

    public ErrorMessage(string MessageName, string SensorName, string ErrorTime, string ValueType, int position)
    {
        this.name = MessageName;
        this.sensorNo = SensorName;
        this.time = ErrorTime;
        this.objectType = ValueType;
        this.address = position;
    }

}
public class Client
{
    public string url;

    public Client(string url)
    {
        this.url = url;
    }

    public virtual string TestConnection()
    {
        // test connection
        return "1.8907";
    }
}

public class Machine
{
    public List<ErrorMessage> errorMessages = new List<ErrorMessage>();

    public string name;

    public Machine(string name)
    {
        this.name = name;
    }

    // update the errorMessages list through certain evaluation matrix
    public virtual List<ErrorMessage> ReportErrors() { return errorMessages; }
}

public class Server
{
    public virtual void ReadData() { }

    public virtual List<ErrorMessage> ReportErrors() { return new List<ErrorMessage>(); }
}


public class Panel
{
    // private OPCUAMachine1 machine1;
    List<Server> servers = new List<Server>();

    public Panel()
    {
        //OPCUAMachine1 oPCUAMachine1 = new OPCUAMachine1("opc.tcp://192.168.1.123:62640", "PacketWrapMachine");
        //OPCUAMachine2 oPCUAMachine2 = new OPCUAMachine2("opc.tcp://192.168.1.123:62640", "FilmMachine");
        //ModbusTCPMachine1 modbusTCPMachine1 = new ModbusTCPMachine1("192.168.1.123", "TearTapeMachine");
        //ModbusTCPMachine2 modbusTCPMachine2 = new ModbusTCPMachine2("192.168.1.123", "PacketEntryMachine");
        ADSMachine1 aDSMachine1 = new ADSMachine1("localhost", "GeneralMachine");
        //ADSMachine2 aDSMachine2 = new ADSMachine2("localhost", "MotorizationMachine");
        //servers.Add(oPCUAMachine1);
        //servers.Add(oPCUAMachine2);
        servers.Add(aDSMachine1);
        //servers.Add(aDSMachine2);
        //servers.Add(modbusTCPMachine1);
        //servers.Add(modbusTCPMachine2);
    }

    public string generateKey(string sensorNo, int address)
    {
        return String.Format("{0}_{1}", sensorNo, address);
    }

    public void ReadAllData()
    {
        foreach (Server server in servers)
        {
            server.ReadData();
        }
    }

    public List<ErrorMessage> ReportAllErrors()
    {
        List<ErrorMessage> errorMessages = new List<ErrorMessage>();
        foreach (Server server in servers)
        {
            errorMessages.AddRange(server.ReportErrors());
        }
        return errorMessages;
    }


    public List<ErrorMessage> TransferDataWrapper()
    {
        this.ReadAllData();
        return this.ReportAllErrors();
    }
}