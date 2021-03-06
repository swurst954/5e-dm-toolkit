﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TeamAlpha.GoldenOracle.Models
{
    public class Damage
    {
        public int ID { get; set; }
        [DisplayName("Dice Count")]
        public string Dice_Count { get; set; }
        [DisplayName("Dice Value")]
        public string Dice_Value { get; set; }
        [DisplayName("Damage Type")]
        public DamageType Damage_Type { get; set; }
    }
}