using System.Collections.Generic;

namespace SundaySchool
{
    public enum Gender { Male, Female };

    public class Profile
    {
        #region Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public List<string> Allergies { get; set; }
        public bool WaitForParent { get; set; }
        public string PictureFileName { get; set; }
        public int BarCode { get; set; }

        #endregion

        public Profile()
        {
            FirstName = "";
            LastName = "";
            Age = -1;
            Gender = Gender.Female;
            Allergies = new List<string>();
            WaitForParent = false;
            PictureFileName = "";
            BarCode = -1;
        }
    }
}
