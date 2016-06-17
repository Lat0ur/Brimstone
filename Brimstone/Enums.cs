﻿namespace Brimstone
{
	public enum GameTag
	{
		TAG_SCRIPT_DATA_NUM_1 = 2,
		TAG_SCRIPT_DATA_NUM_2 = 3,
		TAG_SCRIPT_DATA_ENT_1 = 4,
		TAG_SCRIPT_DATA_ENT_2 = 5,
		MISSION_EVENT = 6,
		TIMEOUT = 7,
		TURN_START = 8,
		TURN_TIMER_SLUSH = 9,
		PREMIUM = 12,
		GOLD_REWARD_STATE = 13,
		PLAYSTATE = 17,
		LAST_AFFECTED_BY = 18,
		STEP = 19,
		TURN = 20,
		FATIGUE = 22,
		CURRENT_PLAYER = 23,
		FIRST_PLAYER = 24,
		RESOURCES_USED = 25,
		RESOURCES = 26,
		HERO_ENTITY = 27,
		MAXHANDSIZE = 28,
		STARTHANDSIZE = 29,
		PLAYER_ID = 30,
		TEAM_ID = 31,
		TRIGGER_VISUAL = 32,
		RECENTLY_ARRIVED = 33,
		PROTECTING = 34,
		PROTECTED = 35,
		DEFENDING = 36,
		PROPOSED_DEFENDER = 37,
		ATTACKING = 38,
		PROPOSED_ATTACKER = 39,
		ATTACHED = 40,
		EXHAUSTED = 43,
		DAMAGE = 44,
		HEALTH = 45,
		ATK = 47,
		COST = 48,
		ZONE = 49,
		CONTROLLER = 50,
		OWNER = 51,
		DEFINITION = 52,
		ENTITY_ID = 53,
		HISTORY_PROXY = 54,
		COPY_DEATHRATTLE = 55,
		ELITE = 114,
		MAXRESOURCES = 176,
		CARD_SET = 183,
		CARDTEXT_INHAND = 184,
		CARDNAME = 185,
		CARD_ID = 186,
		DURABILITY = 187,
		SILENCED = 188,
		WINDFURY = 189,
		TAUNT = 190,
		STEALTH = 191,
		SPELLPOWER = 192,
		DIVINE_SHIELD = 194,
		CHARGE = 197,
		NEXT_STEP = 198,
		CLASS = 199,
		CARDRACE = 200,
		FACTION = 201,
		CARDTYPE = 202,
		RARITY = 203,
		STATE = 204,
		SUMMONED = 205,
		FREEZE = 208,
		ENRAGED = 212,
		OVERLOAD = 215,
		LOYALTY = 216,
		DEATHRATTLE = 217,
		BATTLECRY = 218,
		SECRET = 219,
		COMBO = 220,
		CANT_HEAL = 221,
		CANT_DAMAGE = 222,
		CANT_SET_ASIDE = 223,
		CANT_REMOVE_FROM_GAME = 224,
		CANT_READY = 225,
		CANT_EXHAUST = 226,
		CANT_ATTACK = 227,
		CANT_TARGET = 228,
		CANT_DESTROY = 229,
		CANT_DISCARD = 230,
		CANT_PLAY = 231,
		CANT_DRAW = 232,
		INCOMING_HEALING_MULTIPLIER = 233,
		INCOMING_HEALING_ADJUSTMENT = 234,
		INCOMING_HEALING_CAP = 235,
		INCOMING_DAMAGE_MULTIPLIER = 236,
		INCOMING_DAMAGE_ADJUSTMENT = 237,
		INCOMING_DAMAGE_CAP = 238,
		CANT_BE_HEALED = 239,
		CANT_BE_DAMAGED = 240,
		CANT_BE_SET_ASIDE = 241,
		CANT_BE_REMOVED_FROM_GAME = 242,
		CANT_BE_READIED = 243,
		CANT_BE_EXHAUSTED = 244,
		CANT_BE_ATTACKED = 245,
		CANT_BE_TARGETED = 246,
		CANT_BE_DESTROYED = 247,
		CANT_BE_SUMMONING_SICK = 253,
		FROZEN = 260,
		JUST_PLAYED = 261,
		LINKED_ENTITY = 262,
		ZONE_POSITION = 263,
		CANT_BE_FROZEN = 264,
		COMBO_ACTIVE = 266,
		CARD_TARGET = 267,
		NUM_CARDS_PLAYED_THIS_TURN = 269,
		CANT_BE_TARGETED_BY_OPPONENTS = 270,
		NUM_TURNS_IN_PLAY = 271,
		NUM_TURNS_LEFT = 272,
		OUTGOING_DAMAGE_CAP = 273,
		OUTGOING_DAMAGE_ADJUSTMENT = 274,
		OUTGOING_DAMAGE_MULTIPLIER = 275,
		OUTGOING_HEALING_CAP = 276,
		OUTGOING_HEALING_ADJUSTMENT = 277,
		OUTGOING_HEALING_MULTIPLIER = 278,
		INCOMING_ABILITY_DAMAGE_ADJUSTMENT = 279,
		INCOMING_COMBAT_DAMAGE_ADJUSTMENT = 280,
		OUTGOING_ABILITY_DAMAGE_ADJUSTMENT = 281,
		OUTGOING_COMBAT_DAMAGE_ADJUSTMENT = 282,
		OUTGOING_ABILITY_DAMAGE_MULTIPLIER = 283,
		OUTGOING_ABILITY_DAMAGE_CAP = 284,
		INCOMING_ABILITY_DAMAGE_MULTIPLIER = 285,
		INCOMING_ABILITY_DAMAGE_CAP = 286,
		OUTGOING_COMBAT_DAMAGE_MULTIPLIER = 287,
		OUTGOING_COMBAT_DAMAGE_CAP = 288,
		INCOMING_COMBAT_DAMAGE_MULTIPLIER = 289,
		INCOMING_COMBAT_DAMAGE_CAP = 290,
		CURRENT_SPELLPOWER = 291,
		ARMOR = 292,
		MORPH = 293,
		IS_MORPHED = 294,
		TEMP_RESOURCES = 295,
		OVERLOAD_OWED = 296,
		NUM_ATTACKS_THIS_TURN = 297,
		NEXT_ALLY_BUFF = 302,
		MAGNET = 303,
		FIRST_CARD_PLAYED_THIS_TURN = 304,
		MULLIGAN_STATE = 305,
		TAUNT_READY = 306,
		STEALTH_READY = 307,
		CHARGE_READY = 308,
		CANT_BE_TARGETED_BY_ABILITIES = 311,
		SHOULDEXITCOMBAT = 312,
		CREATOR = 313,
		CANT_BE_DISPELLED = 314,
		PARENT_CARD = 316,
		NUM_MINIONS_PLAYED_THIS_TURN = 317,
		PREDAMAGE = 318,
		TARGETING_ARROW_TEXT = 325,
		ENCHANTMENT_BIRTH_VISUAL = 330,
		ENCHANTMENT_IDLE_VISUAL = 331,
		CANT_BE_TARGETED_BY_HERO_POWERS = 332,
		HEALTH_MINIMUM = 337,
		TAG_ONE_TURN_EFFECT = 338,
		SILENCE = 339,
		COUNTER = 340,
		ARTISTNAME = 342,
		HAND_REVEALED = 348,
		ADJACENT_BUFF = 350,
		FLAVORTEXT = 351,
		FORCED_PLAY = 352,
		LOW_HEALTH_THRESHOLD = 353,
		SPELLPOWER_DOUBLE = 356,
		HEALING_DOUBLE = 357,
		NUM_OPTIONS_PLAYED_THIS_TURN = 358,
		TO_BE_DESTROYED = 360,
		AURA = 362,
		POISONOUS = 363,
		HOW_TO_EARN = 364,
		HOW_TO_EARN_GOLDEN = 365,
		HERO_POWER_DOUBLE = 366,
		AI_MUST_PLAY = 367,
		NUM_MINIONS_PLAYER_KILLED_THIS_TURN = 368,
		NUM_MINIONS_KILLED_THIS_TURN = 369,
		AFFECTED_BY_SPELL_POWER = 370,
		EXTRA_DEATHRATTLES = 371,
		START_WITH_1_HEALTH = 372,
		IMMUNE_WHILE_ATTACKING = 373,
		MULTIPLY_HERO_DAMAGE = 374,
		MULTIPLY_BUFF_VALUE = 375,
		CUSTOM_KEYWORD_EFFECT = 376,
		TOPDECK = 377,
		CANT_BE_TARGETED_BY_BATTLECRIES = 379,
		SHOWN_HERO_POWER = 380,
		DEATHRATTLE_RETURN_ZONE = 382,
		STEADY_SHOT_CAN_TARGET = 383,
		DISPLAYED_CREATOR = 385,
		POWERED_UP = 386,
		SPARE_PART = 388,
		FORGETFUL = 389,
		CAN_SUMMON_MAXPLUSONE_MINION = 390,
		OBFUSCATED = 391,
		BURNING = 392,
		OVERLOAD_LOCKED = 393,
		NUM_TIMES_HERO_POWER_USED_THIS_GAME = 394,
		CURRENT_HEROPOWER_DAMAGE_BONUS = 395,
		HEROPOWER_DAMAGE = 396,
		LAST_CARD_PLAYED = 397,
		NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_TURN = 398,
		NUM_CARDS_DRAWN_THIS_TURN = 399,
		AI_ONE_SHOT_KILL = 400,
		EVIL_GLOW = 401,
		HIDE_COST = 402,
		INSPIRE = 403,
		RECEIVES_DOUBLE_SPELLDAMAGE_BONUS = 404,
		HEROPOWER_ADDITIONAL_ACTIVATIONS = 405,
		HEROPOWER_ACTIVATIONS_THIS_TURN = 406,
		REVEALED = 410,
		NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_GAME = 412,
		CANNOT_ATTACK_HEROES = 413,
		LOCK_AND_LOAD = 414,
		TREASURE = 415,
		SHADOWFORM = 416,
		NUM_FRIENDLY_MINIONS_THAT_ATTACKED_THIS_TURN = 417,
		NUM_RESOURCES_SPENT_THIS_GAME = 418,
		CHOOSE_BOTH = 419,
		ELECTRIC_CHARGE_LEVEL = 420,
		HEAVILY_ARMORED = 421,
		DONT_SHOW_IMMUNE = 422,
		RITUAL = 424,
		PREHEALING = 425,
		APPEAR_FUNCTIONALLY_DEAD = 426,
		OVERLOAD_THIS_GAME = 427,
		SPELLS_COST_HEALTH = 431,
		HISTORY_PROXY_NO_BIG_CARD = 432,
		PROXY_CTHUN = 434,
		TRANSFORMED_FROM_CARD = 435,
		CTHUN = 436,
		CAST_RANDOM_SPELLS = 437,
		SHIFTING = 438,
		EMBRACE_THE_SHADOW = 442,
		CHOOSE_ONE = 443,
		EXTRA_ATTACKS_THIS_TURN = 444,
		SEEN_CTHUN = 445,
		_COUNT,

		// Log-specific
		WEAPON = 334,

		// Card definition-specific
		Collectible = 321
	}

	public enum CardSet
	{
		INVALID,
		TEST_TEMPORARY,
		CORE,
		EXPERT1,
		REWARD,
		MISSIONS,
		DEMO,
		NONE,
		CHEAT,
		BLANK,
		DEBUG_SP,
		PROMO,
		FP1,
		PE1,
		BRM,
		TGT,
		CREDITS,
		HERO_SKINS,
		TB,
		SLUSH,
		LOE,
		OG,
		OG_RESERVE
	}

	public enum CardType
	{
		INVALID,
		GAME,
		PLAYER,
		HERO,
		MINION,
		SPELL,
		ENCHANTMENT,
		WEAPON,
		ITEM,
		TOKEN,
		HERO_POWER
	}

	public enum CardClass
	{
		INVALID,
		DEATHKNIGHT,
		DRUID,
		HUNTER,
		MAGE,
		PALADIN,
		PRIEST,
		ROGUE,
		SHAMAN,
		WARLOCK,
		WARRIOR,
		DREAM
	}

	public enum GameState
	{
		INVALID,
		LOADING,
		RUNNING,
		COMPLETE
	}

	public enum Faction
	{
		INVALID,
		HORDE,
		ALLIANCE,
		NEUTRAL
	}

	public enum MulliganState
	{
		INVALID,
		INPUT,
		DEALING,
		WAITING,
		DONE
	}

	public enum PlayState
	{
		INVALID,
		PLAYING,
		WINNING,
		LOSING,
		WON,
		LOST,
		TIED,
		DISCONNECTED,
		CONCEDED
	}

	public enum Race
	{
		INVALID,
		BLOODELF,
		DRAENEI,
		DWARF,
		GNOME,
		GOBLIN,
		HUMAN,
		NIGHTELF,
		ORC,
		TAUREN,
		TROLL,
		UNDEAD,
		WORGEN,
		GOBLIN2,
		MURLOC,
		DEMON,
		SCOURGE,
		MECHANICAL,
		ELEMENTAL,
		OGRE,
		PET,
		TOTEM,
		NERUBIAN,
		PIRATE,
		DRAGON
	}

	public enum Rarity
	{
		INVALID,
		COMMON,
		FREE,
		RARE,
		EPIC,
		LEGENDARY
	}

	public enum Step
	{
		INVALID,
		BEGIN_FIRST,
		BEGIN_SHUFFLE,
		BEGIN_DRAW,
		BEGIN_MULLIGAN,
		MAIN_BEGIN,
		MAIN_READY,
		MAIN_RESOURCE,
		MAIN_DRAW,
		MAIN_START,
		MAIN_ACTION,
		MAIN_COMBAT,
		MAIN_END,
		MAIN_NEXT,
		FINAL_WRAPUP,
		FINAL_GAMEOVER,
		MAIN_CLEANUP,
		MAIN_START_TRIGGERS
	}

	public enum Zone
	{
		INVALID,
		PLAY,
		DECK,
		HAND,
		GRAVEYARD,
		REMOVEDFROMGAME,
		SETASIDE,
		SECRET,
		_COUNT
	}

	public enum ChoiceType
	{
		INVALID,
		MULLIGAN,
		GENERAL
	}

	public enum EnchantmentVisual
	{
		INVALID,
		POSITIVE,
		NEGATIVE,
		NEUTRAL
	}

	public enum GoldRewardState
	{
		INVALID,
		ELIGIBLE,
		WRONG_GAME_TYPE,
		ALREADY_CAPPED,
		BAD_RATING,
		SHORT_GAME,
		OVER_CAIS
	}

	public enum PlayRequirements
	{
		NONE,
		REQ_MINION_TARGET,
		REQ_FRIENDLY_TARGET,
		REQ_ENEMY_TARGET,
		REQ_DAMAGED_TARGET,
		REQ_ENCHANTED_TARGET,
		REQ_FROZEN_TARGET,
		REQ_CHARGE_TARGET,
		REQ_TARGET_MAX_ATTACK,
		REQ_NONSELF_TARGET,
		REQ_TARGET_WITH_RACE,
		REQ_TARGET_TO_PLAY,
		REQ_NUM_MINION_SLOTS,
		REQ_WEAPON_EQUIPPED,
		REQ_ENOUGH_MANA,
		REQ_YOUR_TURN,
		REQ_NONSTEALTH_ENEMY_TARGET,
		REQ_HERO_TARGET,
		REQ_SECRET_CAP,
		REQ_MINION_CAP_IF_TARGET_AVAILABLE,
		REQ_MINION_CAP,
		REQ_TARGET_ATTACKED_THIS_TURN,
		REQ_TARGET_IF_AVAILABLE,
		REQ_MINIMUM_ENEMY_MINIONS,
		REQ_TARGET_FOR_COMBO,
		REQ_NOT_EXHAUSTED_ACTIVATE,
		REQ_UNIQUE_SECRET,
		REQ_TARGET_TAUNTER,
		REQ_CAN_BE_ATTACKED,
		REQ_ACTION_PWR_IS_MASTER_PWR,
		REQ_TARGET_MAGNET,
		REQ_ATTACK_GREATER_THAN_0,
		REQ_ATTACKER_NOT_FROZEN,
		REQ_HERO_OR_MINION_TARGET,
		REQ_CAN_BE_TARGETED_BY_SPELLS,
		REQ_SUBCARD_IS_PLAYABLE,
		REQ_TARGET_FOR_NO_COMBO,
		REQ_NOT_MINION_JUST_PLAYED,
		REQ_NOT_EXHAUSTED_HERO_POWER,
		REQ_CAN_BE_TARGETED_BY_OPPONENTS,
		REQ_ATTACKER_CAN_ATTACK,
		REQ_TARGET_MIN_ATTACK,
		REQ_CAN_BE_TARGETED_BY_HERO_POWERS,
		REQ_ENEMY_TARGET_NOT_IMMUNE,
		REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY,
		REQ_MINIMUM_TOTAL_MINIONS,
		REQ_MUST_TARGET_TAUNTER,
		REQ_UNDAMAGED_TARGET,
		REQ_CAN_BE_TARGETED_BY_BATTLECRIES,
		REQ_STEADY_SHOT,
		REQ_MINION_OR_ENEMY_HERO,
		REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND,
		REQ_LEGENDARY_TARGET,
		REQ_FRIENDLY_MINION_DIED_THIS_TURN,
		REQ_FRIENDLY_MINION_DIED_THIS_GAME,
		REQ_ENEMY_WEAPON_EQUIPPED,
		REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS,
		REQ_TARGET_WITH_BATTLECRY,
		REQ_TARGET_WITH_DEATHRATTLE,
		REQ_DRAG_TO_PLAY
	}
}