using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SundaySchool
{
    public enum Gender { Male, Female };

    public class Profile : INotifyPropertyChanged
    {
        #region Fields

        private string m_firstName;
        private string m_lastName;
        private uint m_age;
        private Gender m_gender;
        private List<string> m_allergies;
        private bool m_waitForParent;
        private string m_pictureFileName;
        private int m_id;

        #endregion

        #region Properties

        public string FirstName
        {
            get { return m_firstName; }
            set
            {
                m_firstName = value;
                NotifiyPropertyChanged();
            }
        }

        public string LastName
        {
            get { return m_lastName; }
            set
            {
                m_lastName = value;
                NotifiyPropertyChanged();
            }
        }

        public uint Age
        {
            get { return m_age; }
            set
            {
                m_age = value;
                NotifiyPropertyChanged();
            }
        }

        public Gender Gender
        {
            get { return m_gender; }
            set
            {
                m_gender = value;
                NotifiyPropertyChanged();
            }
        }

        public List<string> Allergies
        {
            get { return m_allergies; }
            set
            {
                m_allergies = value;
                NotifiyPropertyChanged();
            }
        }

        public bool WaitForParent
        {
            get { return m_waitForParent; }
            set
            {
                m_waitForParent = value;
                NotifiyPropertyChanged();
            }
        }

        public string PictureFileName
        {
            get { return m_pictureFileName; }
            set
            {
                m_pictureFileName = value;
                NotifiyPropertyChanged();
            }
        }

        public int Id
        {
            get { return m_id; }
            set
            {
                m_id = value;
                NotifiyPropertyChanged();
            }
        }

        #endregion

        public Profile()
        {
            FirstName = "";
            LastName = "";
            Age = 0;
            Gender = Gender.Female;
            Allergies = new List<string>();
            WaitForParent = false;
            PictureFileName = "";
            Id = -1;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifiyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
