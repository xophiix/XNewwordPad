using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XNewwordPadCS
{
    /// <summary>
    /// 单一生词本
    /// </summary>
    public partial class WordPad
    {
        private ArrayList m_words = new ArrayList();
        private Dictionary<string, int> m_lookupTable = new Dictionary<string, int>();
        private DateTime m_earliestAddTime = new DateTime(9058,12,31);
        private DateTime m_latestAddTime = new DateTime(1000,1,1);

        public String Name { get; set; }

        public DateTime EarliestAddTime { get { return m_earliestAddTime; } }
        public DateTime LatestAddTime { get { return m_latestAddTime; } }

        public WordPad( String name )
        {
            Name = name;
        }

        public ArrayList Words
        {
            get { return m_words; }
        }

        public ArrayList GetWordsByTimeRange( DateTime startTime, DateTime endTime )
        {
            ArrayList results = new ArrayList();

            if (startTime.CompareTo(endTime) > 0)
                return results;

            foreach ( NewWordItem word in m_words )
            {
                if (word.AddTime.CompareTo(startTime) >= 0
                    && word.AddTime.CompareTo(endTime) <= 0)
                    results.Add(word);
            }

            return results;
        }

        public bool AddWord( NewWordItem word )
        {
            int index;
            if (m_lookupTable.TryGetValue(word.Name, out index))
                return false;

            m_words.Add(word);
            m_lookupTable[ word.Name ] = m_words.IndexOf(word);

            if (m_earliestAddTime.CompareTo(word.AddTime) > 0)
                m_earliestAddTime = word.AddTime;

            if (m_latestAddTime.CompareTo(word.AddTime) < 0)
                m_latestAddTime = word.AddTime;

            return true;
        }

        public bool DelWord( String wordName )
        {
            int index = -1;
            if ( !m_lookupTable.TryGetValue( wordName, out index ) )
                return false;

            m_words.RemoveAt( index );
            m_lookupTable.Remove( wordName );

            // TODO: update add time

            return true;
        }

        public NewWordItem FindWord( String Keyword )
        {
            int index = -1;
            if (!m_lookupTable.TryGetValue(Keyword, out index))
                return null;

            return (NewWordItem)m_words[index];
        }
    }
}
