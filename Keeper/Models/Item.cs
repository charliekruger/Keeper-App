using System;

using Newtonsoft.Json;

namespace Keeper
{
    public class Item : ObservableObject
    {
        private string id = string.Empty;
        private string text = string.Empty;
        private string description = string.Empty;

        [JsonIgnore]
        public string Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }


    }
}
