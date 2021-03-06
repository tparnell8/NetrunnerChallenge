﻿using System;
using System.Linq;

namespace NetrunnerChallenge.Data
{
    public class Generator
    {
        static readonly string Chars = "abcdefghijklmnopqrstuvwxyz0123456789";

        public string GenerateRandomString()
        {
            var random = new Random();
            return new string(Chars
                .Select(c => Chars[random.Next(Chars.Length)])
                .Take(8)
                .ToArray());
        }
    }
}