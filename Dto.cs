﻿namespace src.ServiceWithDependencies
{
    public class Dto
    {
        public Dto(int? id, string name)
        {
            Id = id;
            Name = name;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
    }
}