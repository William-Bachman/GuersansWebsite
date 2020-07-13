using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMvcWebsite.Models
{
    public enum MoveUnlockRarity
    {
        TwoStar,
        ThreeStar,
        FourStar,
        FiveStar


    }
    public class CharacterMovesets
    {
        public string MoveDescription { get; set; }
        public string MoveName { get; set; }
        public int MoveCharge { get; set; }
        public MoveUnlockRarity unlockRarity { get; set; }

    }
}