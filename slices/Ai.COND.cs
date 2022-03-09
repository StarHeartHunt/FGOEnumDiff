public enum Ai.COND // TypeDefIndex: 6190
{
	// Fields
	public int value__; // 0x0
	public const Ai.COND NONE = 0;
	public const Ai.COND HP_HIGHER = 10;
	public const Ai.COND HP_LOWER = 11;
	public const Ai.COND ACTCOUNT = 20;
	public const Ai.COND ACTCOUNT_MULTIPLE = 21;
	public const Ai.COND TURN = 30;
	public const Ai.COND TURN_MULTIPLE = 31;
	public const Ai.COND BEFORE_ACT_ID = 40;
	public const Ai.COND BEFORE_ACT_TYPE = 41;
	public const Ai.COND BEFORE_NOT_ACT_ID = 42;
	public const Ai.COND BEFORE_NOT_ACT_TYPE = 43;
	public const Ai.COND CHECK_SELF_BUFF = 50;
	public const Ai.COND CHECK_SELF_INDIVIDUALITY = 51;
	public const Ai.COND CHECK_PT_BUFF = 52;
	public const Ai.COND CHECK_PT_INDIVIDUALITY = 53;
	public const Ai.COND CHECK_OPPONENT_BUFF = 55;
	public const Ai.COND CHECK_OPPONENT_INDIVIDUALITY = 56;
	public const Ai.COND CHECK_SELF_BUFF_INDIVIDUALITY = 57;
	public const Ai.COND CHECK_PT_BUFF_INDIVIDUALITY = 58;
	public const Ai.COND CHECK_OPPONENT_BUFF_INDIVIDUALITY = 59;
	public const Ai.COND CHECK_SELF_NPTURN = 60;
	public const Ai.COND CHECK_PT_LOWER_NPTURN = 61;
	public const Ai.COND CHECK_OPPONENT_HEIGHT_NPGAUGE = 62;
	public const Ai.COND ACTCOUNT_THISTURN = 63;
	public const Ai.COND CHECK_PT_HP_HIGHER = 64;
	public const Ai.COND CHECK_PT_HP_LOWER = 65;
	public const Ai.COND CHECK_SELF_NOT_BUFF_INDIVIDUALITY = 66;
	public const Ai.COND TURN_AND_ACTCOUNT_THISTURN = 67;
	public const Ai.COND FIELDTURN = 68;
	public const Ai.COND FIELDTURN_MULTIPLE = 69;
	public const Ai.COND CHECK_PT_LOWER_TDTURN = 70;
	public const Ai.COND RAID_HP_HIGHER = 71;
	public const Ai.COND RAID_HP_LOWER = 72;
	public const Ai.COND RAID_COUNT_HIGHER = 73;
	public const Ai.COND RAID_COUNT_LOWER = 74;
	public const Ai.COND RAID_COUNT_VALUE_HIGHER = 75;
	public const Ai.COND RAID_COUNT_VALUE_LOWER = 76;
	public const Ai.COND CHECK_SPACE = 77;
	public const Ai.COND TURN_HIGHER = 78;
	public const Ai.COND TURN_LOWER = 79;
	public const Ai.COND CHARACTOR_TURN_HIGHER = 80;
	public const Ai.COND CHARACTOR_TURN_LOWER = 81;
	public const Ai.COND COUNT_ALIVE_PT = 82;
	public const Ai.COND COUNT_ALIVE_OPPONENT = 83;
	public const Ai.COND COUNT_PT_REST_HIGHER = 84;
	public const Ai.COND COUNT_PT_REST_LOWER = 85;
	public const Ai.COND COUNT_OPPONENT_REST_HIGHER = 86;
	public const Ai.COND COUNT_OPPONENT_REST_LOWER = 87;
	public const Ai.COND COUNT_ITEM_HIGHER = 88;
	public const Ai.COND COUNT_ITEM_LOWER = 89;
	public const Ai.COND CHECK_SELF_BUFFCOUNT_INDIVIDUALITY = 90;
	public const Ai.COND CHECK_PT_BUFFCOUNT_INDIVIDUALITY = 91;
	public const Ai.COND CHECK_SELF_BUFF_ACTIVE = 92;
	public const Ai.COND CHECK_PT_BUFF_ACTIVE = 93;
	public const Ai.COND CHECK_OPPONENT_BUFF_ACTIVE = 94;
	public const Ai.COND COUNT_ENEMY_COMMAND_SPELL_HIGHER = 95;
	public const Ai.COND CHECK_PT_ALL_INDIVIDUALITY = 96;
	public const Ai.COND CHECK_OPPONENT_ALL_INDIVIDUALITY = 97;
	public const Ai.COND STAR_HIGHER = 98;
	public const Ai.COND STAR_LOWER = 99;
	public const Ai.COND CHECK_OPPONENT_HP_HIGHER = 100;
	public const Ai.COND CHECK_OPPONENT_HP_LOWER = 101;
	public const Ai.COND CHECK_TARGET_POSITION = 102;
	public const Ai.COND CHECK_SELF_BUFF_ACTIVE_AND_PASSIVE_INDIVIDUALITY = 103;
	public const Ai.COND CHECK_PT_BUFF_ACTIVE_AND_PASSIVE_INDIVIDUALITY = 104;
	public const Ai.COND CHECK_OPPONENT_BUFF_ACTIVE_AND_PASSIVE_INDIVIDUALITY = 105;
	public const Ai.COND CHECK_PT_ALL_BUFF = 106;
	public const Ai.COND CHECK_OPPONENT_ALL_BUFF = 107;
	public const Ai.COND CHECK_PT_ALL_BUFF_INDIVIDUALITY = 108;
	public const Ai.COND CHECK_OPPONENT_ALL_BUFF_INDIVIDUALITY = 109;
	public const Ai.COND COUNT_ALIVE_PT_ALL = 110;
	public const Ai.COND COUNT_ALIVE_OPPONENT_ALL = 111;
	public const Ai.COND CHECK_PT_ALL_BUFF_ACTIVE = 112;
	public const Ai.COND CHECK_OPPONENT_ALL_BUFF_ACTIVE = 113;
	public const Ai.COND COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_PT = 114;
	public const Ai.COND COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_PT_ALL = 115;
	public const Ai.COND COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_OPPONENT = 116;
	public const Ai.COND COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_OPPONENT_ALL = 117;
	public const Ai.COND COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_SELF = 118;
	public const Ai.COND COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_PT = 119;
	public const Ai.COND COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_PT_ALL = 120;
	public const Ai.COND COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_OPPONENT = 121;
	public const Ai.COND COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_OPPONENT_ALL = 122;
	public const Ai.COND COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_SELF = 123;
	public const Ai.COND COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_PT = 124;
	public const Ai.COND COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_PT_ALL = 125;
	public const Ai.COND COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_OPPONENT = 126;
	public const Ai.COND COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_OPPONENT_ALL = 127;
	public const Ai.COND COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_SELF = 128;
	public const Ai.COND EXIST_INDIVIDUALITY_OPPONENT_FRONT = 129;
	public const Ai.COND EXIST_INDIVIDUALITY_OPPONENT_CENTER = 130;
	public const Ai.COND EXIST_INDIVIDUALITY_OPPONENT_BACK = 131;
	public const Ai.COND TOTAL_COUNT_HIGHER_INDIVIDUALITY_PT = 132;
	public const Ai.COND TOTAL_COUNT_HIGHER_INDIVIDUALITY_PT_ALL = 133;
	public const Ai.COND TOTAL_COUNT_HIGHER_INDIVIDUALITY_OPPONENT = 134;
	public const Ai.COND TOTAL_COUNT_HIGHER_INDIVIDUALITY_OPPONENT_ALL = 135;
	public const Ai.COND TOTAL_COUNT_HIGHER_INDIVIDUALITY_ALL_FIELD = 136;
	public const Ai.COND TOTAL_COUNT_LOWER_INDIVIDUALITY_PT = 137;
	public const Ai.COND TOTAL_COUNT_LOWER_INDIVIDUALITY_PT_ALL = 138;
	public const Ai.COND TOTAL_COUNT_LOWER_INDIVIDUALITY_OPPONENT = 139;
	public const Ai.COND TOTAL_COUNT_LOWER_INDIVIDUALITY_OPPONENT_ALL = 140;
	public const Ai.COND TOTAL_COUNT_LOWER_INDIVIDUALITY_ALL_FIELD = 141;
	public const Ai.COND TOTAL_COUNT_EQUAL_INDIVIDUALITY_PT = 142;
	public const Ai.COND TOTAL_COUNT_EQUAL_INDIVIDUALITY_PT_ALL = 143;
	public const Ai.COND TOTAL_COUNT_EQUAL_INDIVIDUALITY_OPPONENT = 144;
	public const Ai.COND TOTAL_COUNT_EQUAL_INDIVIDUALITY_OPPONENT_ALL = 145;
	public const Ai.COND TOTAL_COUNT_EQUAL_INDIVIDUALITY_ALL_FIELD = 146;
	public const Ai.COND PT_FRONT_DEAD_EQUAL = 147;
	public const Ai.COND PT_CENTER_DEAD_EQUAL = 148;
	public const Ai.COND PT_BACK_DEAD_EQUAL = 149;
	public const Ai.COND COUNT_HIGHER_INDIVIDUALITY_PT_FRONT = 150;
	public const Ai.COND COUNT_HIGHER_INDIVIDUALITY_PT_CENTER = 151;
	public const Ai.COND COUNT_HIGHER_INDIVIDUALITY_PT_BACK = 152;
	public const Ai.COND COUNT_HIGHER_INDIVIDUALITY_OPPONENT_FRONT = 153;
	public const Ai.COND COUNT_HIGHER_INDIVIDUALITY_OPPONENT_CENTER = 154;
	public const Ai.COND COUNT_HIGHER_INDIVIDUALITY_OPPONENT_BACK = 155;
	public const Ai.COND COUNT_LOWER_INDIVIDUALITY_PT_FRONT = 156;
	public const Ai.COND COUNT_LOWER_INDIVIDUALITY_PT_CENTER = 157;
	public const Ai.COND COUNT_LOWER_INDIVIDUALITY_PT_BACK = 158;
	public const Ai.COND COUNT_LOWER_INDIVIDUALITY_OPPONENT_FRONT = 159;
	public const Ai.COND COUNT_LOWER_INDIVIDUALITY_OPPONENT_CENTER = 160;
	public const Ai.COND COUNT_LOWER_INDIVIDUALITY_OPPONENT_BACK = 161;
	public const Ai.COND COUNT_EQUAL_INDIVIDUALITY_PT_FRONT = 162;
	public const Ai.COND COUNT_EQUAL_INDIVIDUALITY_PT_CENTER = 163;
	public const Ai.COND COUNT_EQUAL_INDIVIDUALITY_PT_BACK = 164;
	public const Ai.COND COUNT_EQUAL_INDIVIDUALITY_OPPONENT_FRONT = 165;
	public const Ai.COND COUNT_EQUAL_INDIVIDUALITY_OPPONENT_CENTER = 166;
	public const Ai.COND COUNT_EQUAL_INDIVIDUALITY_OPPONENT_BACK = 167;
	public const Ai.COND CHECK_PRECEDING_ENEMY = 168;
	public const Ai.COND COUNT_HIGHER_REMAIN_TURN = 169;
	public const Ai.COND COUNT_LOWER_REMAIN_TURN = 170;
	public const Ai.COND COUNT_HIGHER_AI_171 = 171;
	public const Ai.COND COUNT_LOWER_AI_172 = 172;
	public const Ai.COND COUNT_EQUAL_AI_173 = 173;
	public const Ai.COND CHECK_AI_174 = 174;
	public const Ai.COND CHECK_SELF_NPTURN_HIGHER = 175;
	public const Ai.COND CHECK_SELF_NPTURN_LOWER = 176;
	public const Ai.COND CHECK_USE_SKILL_THISTURN = 177;
	public const Ai.COND COUNT_CHAIN_HIGHER = 178;
	public const Ai.COND COUNT_CHAIN_LOWER = 179;
	public const Ai.COND COUNT_CHAIN_EQUAL = 180;
}
