﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeamAlpha.GoldenOracle.Models
{
    public class Classes
    {
        public int ID { get; set; }
        [DisplayName("ID")]
        public string _ID { get; set; }
        public string Index { get; set; }
        public string Name { get; set; }
        [DisplayName("Hit Die")]
        public string Hit_Die { get; set; }
        [DisplayName("Proficiency Choices")]
        public ProficiencyChoices Proficiency_Choices { get; set; }
        public Proficiencies Proficiencies { get; set; }
        [DisplayName("Saving Throws")]
        public SavingThrows Saving_Throws { get; set; }
        [DisplayName("Starting Equipment")]
        public string Starting_Equipment { get; set; }
        [DisplayName("Class Levels")]
        public string Class_Levels { get; set; }
        public string Subclasses { get; set; }
        public string Spellcasting { get; set; }

        public string URL { get; set; }

    }

    public enum ClassesEnum
    {
        Barbarian,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Wizard,

    }
}