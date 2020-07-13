using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMvcWebsite.Models
{
    public enum CharacterClassType
    {
        Acro,
        Trickster,
        Powerhouse,
        Technician,
        Showboat,
        Striker

    }
    public class Characters
    {
        public CharacterClassType classType { get; set; }
        
        public string CharacterName { get; set; }
        public int? AverageTierRanking { get; set; }

        public string ImageUrl { get; set; }
        public string PictureFileName { get; set; }
        public string ReccomndedMoveSet { get; set; }
        public string ClassOfCharacter() {
            string cclass = "";
            switch (classType) {

                case CharacterClassType.Acro:
                    cclass = "Acrobat";
                    break;
                case CharacterClassType.Powerhouse:
                    cclass = "Powerhouse";
                    break;
                case CharacterClassType.Showboat:
                    cclass = "Showboat";
                    break;
                case CharacterClassType.Striker:
                    cclass = "Striker";
                    break;
                case CharacterClassType.Technician:
                    cclass = "Technician";
                    break;
                case CharacterClassType.Trickster:
                    cclass = "Trickster";
                    break;
            }
            return cclass;


                

        }


    }
    public class ListOfCharacters {
        public IList<Characters> characters { get; set; }

    }
}