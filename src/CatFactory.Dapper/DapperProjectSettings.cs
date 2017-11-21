﻿using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Dapper
{
    public class DapperProjectSettings
    {
        public bool ForceOverwrite { get; set; }

        public bool SimplifyDataTypes { get; set; }

        public bool UseAutomaticPropertiesForEntities { get; set; } = true;

        public bool EnableDataBindings { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_insertExclusions;

        public List<string> InsertExclusions
        {
            get
            {
                return m_insertExclusions ?? (m_insertExclusions = new List<string>());
            }
            set
            {
                m_insertExclusions = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_updateExclusions;

        public List<string> UpdateExclusions
        {
            get
            {
                return m_updateExclusions ?? (m_updateExclusions = new List<string>());
            }
            set
            {
                m_updateExclusions = value;
            }
        }
    }
}