using System.ComponentModel;

namespace ActorsApplication.Data
{
    public class Actor:INotifyPropertyChanged
    {
        private string _lastName = "";
        private string _firstName = "";
        private string _profilePicture = "";
        private string _shortBio = "";

        public string LastName 
        {
            get => _lastName;
            set {
                _lastName = value;
                RaisePropChanged(nameof(LastName));
                RaisePropChanged(nameof(FullName));
            }
        }

        public string FirstName { 
            get => _firstName; 
            set
            { 
                _firstName = value; 
                RaisePropChanged(nameof(FirstName));
            
            }
        }

        public string FullName
        {
            get
            {
                return LastName + " " + FirstName;
            }
        }
        public string ProfilePicture 
        { 
            get => _profilePicture;
            set
            { 
                _profilePicture = value; 
                RaisePropChanged(nameof(ProfilePicture));
            
            }
            
        }
        public int BirthYear { get; set; } = 1950;

        public string ShortBio
        {
            get => _shortBio;
            set
            {
                _shortBio = value;
                RaisePropChanged(nameof(ShortBio));

            }

        }

        private void RaisePropChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }

}
