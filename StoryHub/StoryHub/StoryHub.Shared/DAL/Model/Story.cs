using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Controls;

namespace StoryHub.Model
{
    class Story
    {
        private string title = string.Empty;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string subtitle = string.Empty;

        public string Subtitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }

        private List<Author> author = new List<Author>();

        public List<Author> Author
        {
            get { return author; }
            set { author = value; }
        }

        private List<Article> articles = new List<Article>();

        internal List<Article> Articles
        {
            get { return articles; }
            set { articles = value; }
        }

        private bool hasNew = true;

        public bool HasNew
        {
            get { return hasNew; }
            set { hasNew = value; }
        }

        private List<Genre> genres = new List<Genre>();

        public List<Genre> Genres
        {
            get { return genres; }
            set { genres = value; }
        }

        private DateTime lastChange = new DateTime();

        public DateTime LastChange
        {
            get { return lastChange; }
            set { lastChange = value; }
        }

        private string abstrakt = string.Empty;

        public string Abstrakt
        {
            get { return abstrakt; }
            set { abstrakt = value; }
        }

        private Image mainImage = new Image();

        public Image MainImage
        {
            get { return mainImage; }
            set { mainImage = value; }
        }

        private int rating = 0;

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        private List<Restriction> restriction = new List<Restriction>();

        internal List<Restriction> Restriction
        {
            get { return restriction; }
            set { restriction = value; }
        }

        private DateTime added = new DateTime();

        public DateTime Added
        {
            get { return added; }
            set { added = value; }
        }


    }
}
