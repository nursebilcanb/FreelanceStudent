﻿namespace FreelanceStudent.Entity.Entities
{
    public class ForeignLanguage
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }

        public Background Background { get; set; }
        public int BackgroundId { get; set; }
    }
}