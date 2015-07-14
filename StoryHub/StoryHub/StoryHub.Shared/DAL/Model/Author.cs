using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Controls;

namespace StoryHub.Model
{
    public class Author
    {
        private string name=string.Empty;

        public string Name
        {
            set
            {
                name = value;
            }

            get
            {
                return name;
            }
        
        }


        private string description=string.Empty;

        public string Description
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }




        private Image image=new Image();

        public Image Image
        {
            set
            {
                image = value;
            }
            get
            {
                return image;
            }
        }

        
        private List<Story> stories = new List<Story>();

        public List<Story> Stories
        {
            set
            {
                stories = value;
            }
            get
            {
                return stories;
            }
        }








    }
}
