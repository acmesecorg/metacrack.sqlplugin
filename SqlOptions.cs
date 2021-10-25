﻿using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metacrack
{
    [Verb("sql", HelpText = "Parses a sql file into credential text file.")]
    public class SqlOptions
    {
        [Option("table", Default = "`users`")]
        public string Table { get; set; }

        [Option]
        public IEnumerable<string> Columns { get; set; }

        [Option("meta")]
        public IEnumerable<string> MetaColumns { get; set; }

        [Option("s2", HelpText = "Parses SQL using mode 2")]
        public bool S2Mode { get; set; }

        [Option("s3", HelpText = "Parses SQL using mode 3")]
        public bool S3Mode { get; set; }

        [Option("debug", HelpText = "Helps debug sql inputs")]
        public bool Debug { get; set; }

        [Value(0, Required = true, MetaName = "InputPath", HelpText = "The input path to the .sql file(s).")]
        public string InputPath { get; set; }
    }
}
