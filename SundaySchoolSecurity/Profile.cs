using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SundaySchoolSecurity
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

        }
    }
}
