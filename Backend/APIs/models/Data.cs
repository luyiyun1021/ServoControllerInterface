using System;
namespace APIs.models;
static class Constants
{
	public const int MAX_CH_MOTOR_NOMINAL_SPEED_IPR_N = 550;
	public const int MIN_CH_MOTOR_NOMINAL_SPEED_IPR_N = 350;
	public const int MAX_CH_MOTOR_INCREASE_SPEED_STEP_IPR = 30;
	public const int MIN_CH_MOTOR_INCREASE_SPEED_STEP_IPR = 5;
	public const int MAX_CH_MOTOR_DECREASE_SPEED_STEP_IPR = 320;
	public const int MIN_CH_MOTOR_DECREASE_SPEED_STEP_IPR = 120;
	public const int MAX_CH_ENTRY_DOUBLE_PACK_IPR = 359;
	public const int MIN_CH_ENTRY_DOUBLE_PACK_IPR = 0;
	public const int MAX_CH_ENTRY_PACK_ON_CONVEYOR_IPR = 359;
	public const int MIN_CH_ENTRY_PACK_ON_CONVEYOR_IPR = 0;
	public const int MAX_CH_WL_FILM_POSITION_CHECK_ENABLE_IPR = 359;
	public const int MIN_CH_WL_FILM_POSITION_CHECK_ENABLE_IPR = 0;

}

enum ErrorTypes
{
	CELLOPHANER_CHECKS_BYPASSED = 0,
	CARTONER_CHECKS_BYPASSED,
	CH_HEATERS_BY_PASSED,
	CT_HEATERS_BY_PASSED,
	MACCHINA_NELLO_STATO_DI_MARCIA,
	MACCHINA_NELLO_STATO_DI_ATTESA,
	CH_MACHINE_WITHOUT_PRODUCTS,
	CH_COMPRESSORS_BYPASSED,
	MOVE_THE_CH_TO_CH_SLOW_PHASE_START
}

public class Data
{
	public string name;
	public int address;
	public DateTime updateTime;

	public Data(string name, int address, DateTime updateTime)
	{
		this.name = name;
		this.address = address;
		this.updateTime = updateTime;
	}
}
public class DigitalData : Data
{
	public bool val;
	
	public DigitalData(string name, bool val, int address, DateTime updateTime) : base(name, address, updateTime)
    {
		this.val = val;
	}
}

public class IntData : Data
{
	public int val;

	public IntData(string name, int val, int address, DateTime updateTime) : base(name, address, updateTime)
	{
		this.val = val;
	}
}

public class CounterData : Data
{
	public int val;

	public CounterData(string name, int val, int address, DateTime updateTime) : base(name, address, updateTime)
	{
		this.val = val;
	}
}

public class DigitalMeterData : Data
{
	public bool val;

	public DigitalMeterData(string name, bool val, int address, DateTime updateTime) : base(name, address, updateTime)
	{
		this.val = val;
	}
}

public class IntMeterData : Data
{
	public int val;

	public IntMeterData(string name, int val, int address, DateTime updateTime) : base(name, address, updateTime)
	{
		this.val = val;
	}
}
// 通用部件
public class GeneralData
{
	// Digital
	// CELLOPHANER CHECK BYPASS CH检测旁通
	public DigitalData ch_gp_ch_checks_disable_sdp { get; set; }
	// CARTONER CHECK BYPASS CT检测旁通
	public DigitalData ct_gp_ct_checks_disable_sdp { get; set; }
	// HEATERS OFF-LINE 加热器脱机
	public DigitalData ch_gp_heaters_disable_sdp { get; set; }
	// CH MACHINE WITHOUT PRODUCTS CH空运转
	public DigitalData ch_gp_ch_without_product_select_dpr { get; set; }

	// Counter
	// REAL CH PRODUCTION CH实际产量
	public CounterData ch_gp_real_ch_prod_cnt { get; set; }
	// GOOD PACKETS REJECTED 剔除的合格烟包
	public CounterData ch_gp_ch_reject_good_pack_cnt { get; set; }
	// BAD PACKETS REJECTED 剔除的坏包
	public CounterData ch_gp_ch_reject_bad_pack_cnt { get; set; }
	// MACHINE CYCLES WITH PROD. DATA DISABLED 生产数据关闭的机器周期
	public CounterData ch_gp_ch_prod_data_disabled_cnt { get; set; }
	// REAL PACKET PRODUCTION 烟包实际产量
	public CounterData ch_gp_real_ct_prod_cnt_p { get; set; }
	// REJECTED PRODUCTION 剔除产量
	public CounterData ch_gp_rejected_ct_prod_cnt_s { get; set; }
	// MACHINE CYCLES RUNNING EMPTY 机器空转周期
	public CounterData ch_gp_ct_no_production_cnt { get; set; }
	// MACHINE CYCLES WITH PROD. DATA DISABLED 生产数据关闭的机器周期
	public CounterData ch_gp_ct_prod_data_disabled_cnt { get; set; }
	public GeneralData()
	{
		DateTime currTime = DateTime.Now;
		this.ch_gp_ch_checks_disable_sdp = new DigitalData("ch_gp_ch_checks_disable_sdp", false, 0, currTime);
		this.ct_gp_ct_checks_disable_sdp = new DigitalData("ct_gp_ct_checks_disable_sdp", false, 1, currTime);
		this.ch_gp_heaters_disable_sdp = new DigitalData("ch_gp_heaters_disable_sdp", false, 2, currTime);
		this.ch_gp_ch_without_product_select_dpr = new DigitalData("ch_gp_ch_without_product_select_dpr", false, 3, currTime);
		this.ch_gp_real_ch_prod_cnt = new CounterData("ch_gp_real_ch_prod_cnt", 0, 4, currTime);
		this.ch_gp_ch_reject_good_pack_cnt = new CounterData("ch_gp_real_ch_prod_cnt", 0, 5, currTime);
		this.ch_gp_ch_reject_bad_pack_cnt = new CounterData("ch_gp_real_ch_prod_cnt", 0, 6, currTime);
		this.ch_gp_ch_prod_data_disabled_cnt = new CounterData("ch_gp_real_ch_prod_cnt", 0, 7, currTime);
		this.ch_gp_real_ct_prod_cnt_p = new CounterData("ch_gp_real_ch_prod_cnt", 0, 8, currTime);
		this.ch_gp_rejected_ct_prod_cnt_s = new CounterData("ch_gp_real_ch_prod_cnt", 0, 9, currTime);
		this.ch_gp_ct_no_production_cnt = new CounterData("ch_gp_ct_no_production_cnt", 0, 10, currTime);
		this.ch_gp_ct_prod_data_disabled_cnt = new CounterData("ch_gp_real_ch_prod_cnt", 0, 11, currTime);
	}
}

// 透明纸拉带部件
public class TearTapeData
{
	// Digital
	// CH TEAR-TAPE ALIGNMENT CHECK ENABLED CH透明纸拉带对齐检测
	//public DigitalData ch_tape_alignment_enable_dpr { get; set; }
	public IntData ch_tape_alignment_enable_dpr { get; set; }
	public TearTapeData()
    {
		DateTime currTime = DateTime.Now;
		//this.ch_tape_alignment_enable_dpr = new DigitalData("ch_gp_ch_checks_disable_sdp", true, 0, currTime);
		this.ch_tape_alignment_enable_dpr = new IntData("ch_gp_ch_checks_disable_sdp", 10, 1, currTime);
	}
}

// 主电机部件
public class MotorizationData
{
	// Ingeter
	// NOMINAL CH SPEED (RPM) 额定速度
	public IntData ch_motor_nominal_speed_ipr_n { get; set; }
	// CH SPEED INCREMENT (RPM) 速度提升
	public IntData ch_motor_increase_speed_step_ipr { get; set; }
	// CH SPEED REDUCTION (RPM) 速度降低
	public IntData ch_motor_decrease_speed_step_ipr { get; set; }

	// Counter
	// STACK LEVEL INCORRECT 烟包堆叠位置不正确
	public CounterData ch_motor_stack_level_error_counter_cnt { get; set; }

	// Digital Meter
	// SPEED CONDIT. FOR INPHASE STOP 同相停机的速度调节
	public DigitalMeterData ch_motor_stop_in_phase_cond_dfl { get; set; }
	// SPEED CONDIT. FROM PACKER 包装机产生的速度调节
	public DigitalMeterData ch_motor_umi_speed_red_req_dfl { get; set; }
	// SPEED CONDIT. FROM CH FILM CHANGE CH透明纸换卷产生的速度调节
	public DigitalMeterData ch_motor_splice_in_progress_dfl { get; set; }

	// Integer Meter
	// CH ENCODER SPEED CH编码器速度
	public IntMeterData ch_motor_ch_encoder_aen_speed { get; set; }
	// CH ENCODER PHASE CH编码器相位
	public IntMeterData ch_motor_ch_encoder_aen_phase { get; set; }
	// CT ENCODER SPEED CT编码器速度
	public IntMeterData ch_motor_pack_encoder_aen_speed { get; set; }
	// CT ENCODER PHASE CT编码器相位
	public IntMeterData ch_motor_pack_encoder_aen_phase { get; set; }
	// CH SLOW PHASE CH低速相位
	public IntMeterData ch_motor_slow_phase_ifl { get; set; }
	public MotorizationData()
	{
		DateTime currTime = DateTime.Now;
		this.ch_motor_nominal_speed_ipr_n = new IntData("ch_motor_nominal_speed_ipr_n", 450, 0, currTime);
		this.ch_motor_increase_speed_step_ipr = new IntData("ch_motor_increase_speed_step_ipr", 20, 1, currTime);
		this.ch_motor_decrease_speed_step_ipr = new IntData("ch_motor_decrease_speed_step_ipr", 220, 2, currTime);
		this.ch_motor_stack_level_error_counter_cnt = new CounterData("ch_motor_stack_level_error_counter_cnt", 0, 3, currTime);
		this.ch_motor_stop_in_phase_cond_dfl = new DigitalMeterData("ch_motor_stop_in_phase_cond_dfl", false, 4, currTime);
		this.ch_motor_umi_speed_red_req_dfl = new DigitalMeterData("ch_motor_umi_speed_red_req_dfl", false, 5, currTime);
		this.ch_motor_splice_in_progress_dfl = new DigitalMeterData("ch_motor_splice_in_progress_dfl", false, 6, currTime);
		this.ch_motor_ch_encoder_aen_speed = new IntMeterData("ch_motor_ch_encoder_aen_speed", 0, 7, currTime);
		this.ch_motor_ch_encoder_aen_phase = new IntMeterData("ch_motor_ch_encoder_aen_phase", 0, 8, currTime);
		this.ch_motor_pack_encoder_aen_speed = new IntMeterData("ch_motor_pack_encoder_aen_speed", 0, 9, currTime);
		this.ch_motor_pack_encoder_aen_phase = new IntMeterData("ch_motor_pack_encoder_aen_phase", 0, 10, currTime);
		this.ch_motor_slow_phase_ifl = new IntMeterData("ch_motor_slow_phase_ifl", 0, 11, currTime);
	}
}

// CH烟包入口部件
public class PacketEntryData
{
	// Ingeter
	// CHECK PHASE: DOUBLE PACKET ON CH CHAIN (degree) 检测相位：CH传送链存在双包
	public IntData ch_entry_double_pack_ipr { get; set; }
	// CHECK PHASE: PACKET PRESENT ON CH CHAIN (degree) 检测相位：CH传送链上烟包存在
	public IntData ch_entry_pack_on_conveyor_ipr { get; set; }
	public PacketEntryData()
	{
		DateTime currTime = DateTime.Now;
		this.ch_entry_double_pack_ipr = new IntData("ch_entry_double_pack_ipr", 270, 2, currTime);
		this.ch_entry_pack_on_conveyor_ipr = new IntData("ch_entry_pack_on_conveyor_ipr", 105, 3, currTime);
	}
}

// CH包装线部件
public class PacketWrapData
{
	// Ingeter
	// CHECK ENABLE PHASE: CH FILM POSITION (degree) 检测启用相位：CH透明纸检测
	public IntData ch_wl_film_position_check_enable_ipr { get; set; }
	public PacketWrapData()
	{
		DateTime currTime = DateTime.Now;
		this.ch_wl_film_position_check_enable_ipr = new IntData("ch_entry_pack_on_conveyor_ipr", 70, 6, currTime);
	}
}

// CH透明纸部件
public class FilmData
{
	// Counter
	// CH FILM SPLICE FROM AUTOMATIC CHANGE CH透明纸自动更换接头
	public CounterData ch_film_reject_aut_film_splice_cnt_r { get; set; }
	// NUMBER OF CHANGES MADE 更换次数
	public CounterData ch_film_reel_counter_cnt_m { get; set; }
	// CH FILM SPLICE CH透明纸拼接检测
	public CounterData ch_film_reject_film_splice_cnt_r { get; set; }

	// Digital Meter
	// LH FILM REEL UNWINDING 左侧透明纸卷展开
	public DigitalMeterData ch_film_left_reel_unwinding_dfl { get; set; }
	// RH FILM REEL UNWINDING 右侧透明纸卷展开
	public DigitalMeterData ch_film_right_reel_unwinding_dfl { get; set; }
	public FilmData()
	{
		DateTime currTime = DateTime.Now;
		this.ch_film_reject_aut_film_splice_cnt_r = new CounterData("ch_film_reject_aut_film_splice_cnt_r", 0, 1, currTime);
		this.ch_film_reel_counter_cnt_m = new CounterData("ch_film_reel_counter_cnt_m", 0, 2, currTime);
		this.ch_film_reject_film_splice_cnt_r = new CounterData("ch_film_reject_film_splice_cnt_r", 0, 3, currTime);
		this.ch_film_left_reel_unwinding_dfl = new DigitalMeterData("ch_film_left_reel_unwinding_dfl", false, 4, currTime);
		this.ch_film_right_reel_unwinding_dfl = new DigitalMeterData("ch_film_right_reel_unwinding_dfl", false, 5, currTime);
	}
}

