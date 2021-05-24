﻿namespace Orchestra.Changelog
{
    public class ChangelogItem
    {
        public ChangelogItem()
        {
            Type = ChangelogType.Change;
        }

        public string Group { get; set; }

        public ChangelogType Type { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public object Tag { get; set; }
    }
}
