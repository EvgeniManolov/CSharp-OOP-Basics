﻿namespace MordorsCrueltyPlan.MoodModels
{
    public abstract class Mood
    {
        public override string ToString()
        {
            return $"{GetType().Name}";
        }
    }
}