using System;

namespace MotiveMe
{
	/*
		Master Page item menu
	*/
    public class MSPageMenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}