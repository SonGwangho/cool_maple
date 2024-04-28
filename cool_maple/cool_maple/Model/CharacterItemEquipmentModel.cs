using Newtonsoft.Json;

namespace cool_maple.Model
{
    public class CharacterItemEquipmentModel
    {
        [JsonProperty("character_gender")]
        public string CharacterGender { get; set; }

        [JsonProperty("character_class")]
        public string CharacterClass { get; set; }

        [JsonProperty("preset_no")]
        public uint PresetNo { get; set; }

        [JsonProperty("item_equipment")]
        public ItemEquipmentModel[] ItemEquipment { get; set; }

        [JsonProperty("item_equipment_preset_1")]
        public ItemEquipmentModel[] ItemEquipmentPreset1 { get; set; }

        [JsonProperty("item_equipment_preset_2")]
        public ItemEquipmentModel[] ItemEquipmentPreset2 { get; set; }

        [JsonProperty("item_equipment_preset_3")]
        public ItemEquipmentModel[] ItemEquipmentPreset3 { get; set; }

        [JsonProperty("title")]
        public TitleModel Title { get; set; }

        [JsonProperty("dragon_equipment")]
        public ItemEquipmentModel[] DragonEquipment { get; set; }

        [JsonProperty("mechanic_equipment")]
        public ItemEquipmentModel[] MechanicEquipment { get; set; }
    }

    public class ItemEquipmentModel
    {
        [JsonProperty("item_equipment_part")]
        public string ItemEquipmentPart { get; set; }

        [JsonProperty("item_equipment_slot")]
        public string ItemEquipmentSlot { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("item_icon")]
        public string ItemIcon { get; set; }

        [JsonProperty("item_description")]
        public string ItemDescription { get; set; }

        [JsonProperty("item_shape_name")]
        public string ItemShapeName { get; set; }

        [JsonProperty("item_shape_icon")]
        public string ItemShapeIcon { get; set; }

        [JsonProperty("item_gender")]
        public string ItemGender { get; set; }

        [JsonProperty("item_total_option")]
        public ItemTotalOptionModel ItemTotalOption { get; set; }

        [JsonProperty("item_base_option")]
        public ItemBaseOptionModel ItemBaseOption { get; set; }

        [JsonProperty("potential_option_grade")]
        public string PotentialOptionGrade { get; set; }

        [JsonProperty("additional_potential_option_grade")]
        public string AdditionalPotentialOptionGrade { get; set; }

        [JsonProperty("potential_option_1")]
        public string PotentialOption1 { get; set; }

        [JsonProperty("potential_option_2")]
        public string PotentialOption2 { get; set; }

        [JsonProperty("potential_option_3")]
        public string PotentialOption3 { get; set; }

        [JsonProperty("additional_potential_option_1")]
        public string AdditionalPotentialOption1 { get; set; }

        [JsonProperty("additional_potential_option_2")]
        public string AdditionalPotentialOption2 { get; set; }

        [JsonProperty("additional_potential_option_3")]
        public string AdditionalPotentialOption3 { get; set; }

        [JsonProperty("equipment_level_increase")]
        public uint EquipmentLevelIncrease { get; set; }

        [JsonProperty("item_exceptional_option")]
        public ItemExceptionalOptionModel ItemExceptionalOption { get; set; }

        [JsonProperty("item_add_option")]
        public ItemAddOptionModel ItemAddOption { get; set; }

        [JsonProperty("growth_exp")]
        public uint GrowthExp { get; set; }

        [JsonProperty("growth_level")]
        public uint GrowthLevel { get; set; }

        [JsonProperty("scroll_upgrade")]
        public string ScrollUpgrade { get; set; }

        [JsonProperty("cuttable_count")]
        public string CuttableCount { get; set; }

        [JsonProperty("golden_hammer_flag")]
        public string GoldenHammerFlag { get; set; }

        [JsonProperty("scroll_resilience_count")]
        public string ScrollResilienceCount { get; set; }

        [JsonProperty("scroll_upgradable_count")]
        public string ScrollUpgradableCount { get; set; }

        [JsonProperty("soul_name")]
        public string SoulName { get; set; }

        [JsonProperty("soul_option")]
        public string SoulOption { get; set; }

        [JsonProperty("item_etc_option")]
        public ItemEtcOptionModel ItemEtcOption { get; set; }

        [JsonProperty("starforce")]
        public string StarForce { get; set; }

        [JsonProperty("starforce_scroll_flag")]
        public string StarforceScrollFlag { get; set; }

        [JsonProperty("item_starforce_option")]
        public ItemStarforceOptionModel ItemStarforceOption { get; set; }

        [JsonProperty("special_ring_level")]
        public uint SpecialRingLevel { get; set; }
    }

    public class ItemTotalOptionModel
    {
        [JsonProperty("str")]
        public string Str { get; set; }

        [JsonProperty("dex")]
        public string Dex { get; set; }

        [JsonProperty("int")]
        public string Int { get; set; }

        [JsonProperty("luk")]
        public string Luk { get; set; }

        [JsonProperty("max_hp")]
        public string MaxHp { get; set; }

        [JsonProperty("max_mp")]
        public string MaxMp { get; set; }

        [JsonProperty("attack_power")]
        public string AttackPower { get; set; }

        [JsonProperty("magic_power")]
        public string MagicPower { get; set; }

        [JsonProperty("armor")]
        public string Armor { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("jump")]
        public string Jump { get; set; }

        [JsonProperty("boss_damage")]
        public string BossDamage { get; set; }

        [JsonProperty("ignore_monster_armor")]
        public string IgnoreMonsterArmor { get; set; }

        [JsonProperty("all_stat")]
        public string AllStat { get; set; }

        [JsonProperty("damage")]
        public string Damage { get; set; }

        [JsonProperty("equipment_level_decrease")]
        public uint EquipmentLevelDecrease { get; set; }

        [JsonProperty("max_hp_rate")]
        public string MaxHpRate { get; set; }

        [JsonProperty("max_mp_rate")]
        public string MaxMpRate { get; set; }
    }

    public class ItemBaseOptionModel
    {
        [JsonProperty("str")]
        public string Str { get; set; }

        [JsonProperty("dex")]
        public string Dex { get; set; }

        [JsonProperty("int")]
        public string Int { get; set; }

        [JsonProperty("luk")]
        public string Luk { get; set; }

        [JsonProperty("max_hp")]
        public string MaxHp { get; set; }

        [JsonProperty("max_mp")]
        public string MaxMp { get; set; }

        [JsonProperty("attack_power")]
        public string AttackPower { get; set; }

        [JsonProperty("magic_power")]
        public string MagicPower { get; set; }

        [JsonProperty("armor")]
        public string Armor { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("jump")]
        public string Jump { get; set; }

        [JsonProperty("boss_damage")]
        public string BossDamage { get; set; }

        [JsonProperty("ignore_monster_armor")]
        public string IgnoreMonsterArmor { get; set; }

        [JsonProperty("all_stat")]
        public string AllStat { get; set; }

        [JsonProperty("max_hp_rate")]
        public string MaxHpRate { get; set; }

        [JsonProperty("max_mp_rate")]
        public string MaxMpRate { get; set; }

        [JsonProperty("base_equipment_level")]
        public uint BaseEquipmentLevel { get; set; }
    }

    public class ItemExceptionalOptionModel
    {
        [JsonProperty("str")]
        public string Str { get; set; }

        [JsonProperty("dex")]
        public string Dex { get; set; }

        [JsonProperty("int")]
        public string Int { get; set; }

        [JsonProperty("luk")]
        public string Luk { get; set; }

        [JsonProperty("max_hp")]
        public string MaxHp { get; set; }

        [JsonProperty("max_mp")]
        public string MaxMp { get; set; }

        [JsonProperty("attack_power")]
        public string AttackPower { get; set; }

        [JsonProperty("magic_power")]
        public string MagicPower { get; set; }
    }

    public class ItemAddOptionModel
    {
        [JsonProperty("str")]
        public string Str { get; set; }

        [JsonProperty("dex")]
        public string Dex { get; set; }

        [JsonProperty("int")]
        public string Int { get; set; }

        [JsonProperty("luk")]
        public string Luk { get; set; }

        [JsonProperty("max_hp")]
        public string MaxHp { get; set; }

        [JsonProperty("max_mp")]
        public string MaxMp { get; set; }

        [JsonProperty("attack_power")]
        public string AttackPower { get; set; }

        [JsonProperty("magic_power")]
        public string MagicPower { get; set; }

        [JsonProperty("armor")]
        public string Armor { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("jump")]
        public string Jump { get; set; }

        [JsonProperty("boss_damage")]
        public string BossDamage { get; set; }

        [JsonProperty("ignore_monster_armor")]
        public string IgnoreMonsterArmor { get; set; }

        [JsonProperty("all_stat")]
        public string AllStat { get; set; }

        [JsonProperty("damage")]
        public string Damage { get; set; }

        [JsonProperty("equipment_level_decrease")]
        public uint EquipmentLevelDecrease { get; set; }
    }

    public class ItemEtcOptionModel
    {
        [JsonProperty("str")]
        public string Str { get; set; }

        [JsonProperty("dex")]
        public string Dex { get; set; }

        [JsonProperty("int")]
        public string Int { get; set; }

        [JsonProperty("luk")]
        public string Luk { get; set; }

        [JsonProperty("max_hp")]
        public string MaxHp { get; set; }

        [JsonProperty("max_mp")]
        public string MaxMp { get; set; }

        [JsonProperty("attack_power")]
        public string AttackPower { get; set; }

        [JsonProperty("magic_power")]
        public string MagicPower { get; set; }

        [JsonProperty("armor")]
        public string Armor { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("jump")]
        public string Jump { get; set; }
    }

    public class ItemStarforceOptionModel
    {
        [JsonProperty("str")]
        public string Str { get; set; }

        [JsonProperty("dex")]
        public string Dex { get; set; }

        [JsonProperty("int")]
        public string Int { get; set; }

        [JsonProperty("luk")]
        public string Luk { get; set; }

        [JsonProperty("max_hp")]
        public string MaxHp { get; set; }

        [JsonProperty("max_mp")]
        public string MaxMp { get; set; }

        [JsonProperty("attack_power")]
        public string AttackPower { get; set; }

        [JsonProperty("magic_power")]
        public string MagicPower { get; set; }

        [JsonProperty("armor")]
        public string Armor { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("jump")]
        public string Jump { get; set; }
    }

    public class TitleModel
    {
        [JsonProperty("title_name")]
        public string TitleName { get; set; }

        [JsonProperty("title_icon")]
        public string TitleIcon { get; set; }

        [JsonProperty("title_description")]
        public string TitleDescription { get; set; }
    }
}
