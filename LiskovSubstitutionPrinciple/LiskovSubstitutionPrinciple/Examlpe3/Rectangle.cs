using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Examlpe3
{
    /// <summary>
    /// ok, now i know this is a very old school way of doing things, but there is a point to this. 
    /// 
    /// consider the following class. Its a rectangle. its got getters and setters for the 2 properties, height and width and a get area method.
    /// 
    /// anything wrong here so far... not that I can see... lets move to the square class
    /// </summary>
    public class Rectangle
    {
        private int m_height, m_width;
        
        public int GetHeight()
        {
            return m_height;
        }

        public int GetWidth()
        {
            return m_width;
        }

        public virtual void SetHeight (int height)
        {
            m_height = height;
        }

        public virtual void SetWidth(int width)
        {
            m_width = width;
        }
        
        public int GetArea()
        {
            return m_height * m_width;
        }
    }
}
