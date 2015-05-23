﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public T RandomEnumValue<T>()
        {
            var _Random = new Random();
            return Enum
                .GetValues(typeof(T))
                .Cast<T>()
                .OrderBy(x => _Random.Next())
                .FirstOrDefault();
        }
    }
}