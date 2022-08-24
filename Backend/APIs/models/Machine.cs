using System;
namespace APIs.models;

public class GeneralMachine : Machine
{	 
	public GeneralData generalData = new GeneralData();

	public GeneralMachine(string name) : base(name)
    {

    }

	public override List<ErrorMessage> ReportErrors() {
		errorMessages = new List<ErrorMessage>();
		DateTime time = DateTime.Now;
		// Define rules to detect errors from data here
		if (generalData.ch_gp_ch_checks_disable_sdp.val == true)
        {
			int pos = generalData.ch_gp_ch_checks_disable_sdp.address;
			errorMessages.Add(new ErrorMessage("CELLOPHANER CHECKS BYPASSED", name, time.ToString("u"), "S", pos));

		}

		if (generalData.ch_gp_ct_no_production_cnt.val >= 1)
		{
			int pos = generalData.ch_gp_ct_no_production_cnt.address;
			errorMessages.Add(new ErrorMessage("CH MACHINE WITHOUT PRODUCTS", name, time.ToString("u"), "S", pos));
		}

		return errorMessages;
	}
}

public class TearTapeMachine : Machine
{
	public TearTapeData tapeData = new TearTapeData();

	public TearTapeMachine(string name) : base(name)
    {

    }

	public override List<ErrorMessage> ReportErrors()
	{
		errorMessages = new List<ErrorMessage>();
		DateTime time = DateTime.Now;

		if (tapeData.ch_tape_alignment_enable_dpr.val >= 99)
        {
			int pos = tapeData.ch_tape_alignment_enable_dpr.address;
			errorMessages.Add(new ErrorMessage("CH_MACHINE_WITHOUT_PRODUCTS", name, time.ToString("u"), "S", pos));
        }

		return errorMessages;
	} // Define rules to detect errors from data here
}

public class MotorizationMachine : Machine
{
	public MotorizationData motorizationData = new MotorizationData();

	public MotorizationMachine(string name) : base(name)
    {

    }


	public override List<ErrorMessage> ReportErrors() 
	{
		errorMessages = new List<ErrorMessage>();
		DateTime time = DateTime.Now;

		// Define rules to detect errors from data here
		if (motorizationData.ch_motor_stack_level_error_counter_cnt.val >= 5)
		{
			int pos = motorizationData.ch_motor_stack_level_error_counter_cnt.address;
			errorMessages.Add(new ErrorMessage("STACK LEVEL INCORRECT", name, time.ToString("u"), "S", pos));
		}

		if (motorizationData.ch_motor_slow_phase_ifl.val >= 90)
		{
			int pos = motorizationData.ch_motor_slow_phase_ifl.address;
			errorMessages.Add(new ErrorMessage("CH SLOW PHASE INCORRECT", name, time.ToString("u"), "S", pos));
		}

		return errorMessages;
	}
}

public class PacketEntryMachine : Machine
{
	public PacketEntryData packetEntryData = new PacketEntryData();

	public PacketEntryMachine(string name) : base(name)
    {

    }

	public override List<ErrorMessage> ReportErrors()
	{
		DateTime time = DateTime.Now;
		errorMessages = new List<ErrorMessage>();
		if (packetEntryData.ch_entry_double_pack_ipr.val >= 99)
        {
			int pos = packetEntryData.ch_entry_double_pack_ipr.address;
			errorMessages.Add(new ErrorMessage("CH_HEATERS_BY_PASSED", name, time.ToString("u"), "S", pos));
        }

		if (packetEntryData.ch_entry_pack_on_conveyor_ipr.val >= 99)
        {
			int pos = packetEntryData.ch_entry_pack_on_conveyor_ipr.address;
			errorMessages.Add(new ErrorMessage("CT_HEATERS_BY_PASSED", name, time.ToString("u"), "S", pos));
		}

		return errorMessages;
	} // Define rules to detect errors from data here
}

public class PacketWrapMachine : Machine
{
	public PacketWrapData packetWrapData = new PacketWrapData();

	public PacketWrapMachine(string name) : base(name)
    {

    }

	public override List<ErrorMessage> ReportErrors()
	{
		DateTime time = DateTime.Now;
		errorMessages = new List<ErrorMessage>();
        if (packetWrapData.ch_wl_film_position_check_enable_ipr.val >= 359)
        {
            int pos = packetWrapData.ch_wl_film_position_check_enable_ipr.address;
			errorMessages.Add(new ErrorMessage("CARTONER_CHECKS_BYPASSED", name, time.ToString("u"), "S", pos));
            //errorMessages.Add(new ErrorMessage("", name, time.ToString("u"), "S", packetWrapData.ch_wl_film_position_check_enable_ipr.val));
        }

        return errorMessages;
	} // Define rules to detect errors from data here
}

public class FilmMachine : Machine
{
	public FilmData filmData = new FilmData();

	public FilmMachine(string name) : base(name)
    {

    }

	public override List<ErrorMessage> ReportErrors()
	{
		errorMessages = new List<ErrorMessage>();
		DateTime time = DateTime.Now;
		if (filmData.ch_film_reject_aut_film_splice_cnt_r.val <= 20)
        {
			int pos = filmData.ch_film_reject_aut_film_splice_cnt_r.address;
			errorMessages.Add(new ErrorMessage("CH_HEATERS_BY_PASSED", name, time.ToString("u"), "S", pos));
		}

		if (filmData.ch_film_reel_counter_cnt_m.val >= 359)
        {
			int pos = filmData.ch_film_reel_counter_cnt_m.address;
			errorMessages.Add(new ErrorMessage("CT_HEATERS_BY_PASSED", name, time.ToString("u"), "S", pos));
		}

		if (filmData.ch_film_reject_film_splice_cnt_r.val >= 359)
        {
			int pos = filmData.ch_film_reject_film_splice_cnt_r.address;
			errorMessages.Add(new ErrorMessage("MACCHINA_NELLO_STATO_DI_MARCIA", name, time.ToString("u"), "S", pos));
		}

		if (filmData.ch_film_left_reel_unwinding_dfl.val)
        {
			int pos = filmData.ch_film_left_reel_unwinding_dfl.address;
			errorMessages.Add(new ErrorMessage("MACCHINA_NELLO_STATO_DI_ATTESA", name, time.ToString("u"), "S", pos));
		}

		if (filmData.ch_film_right_reel_unwinding_dfl.val)
		{
			int pos = filmData.ch_film_right_reel_unwinding_dfl.address;
			errorMessages.Add(new ErrorMessage("MOVE_THE_CH_TO_CH_SLOW_PHASE_START", name, time.ToString("u"), "S", pos));
		}

		return errorMessages;
	} // Define rules to detect errors from data here
}