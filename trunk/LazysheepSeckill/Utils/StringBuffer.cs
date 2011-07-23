﻿using System;
using System.Text;
using System.Collections.Generic;

namespace Utils
{
    public class StringBuffer
    {
        private StringBuilder m_InnerBuilder = new StringBuilder();

        public StringBuilder InnerBuilder
        {
            get { return m_InnerBuilder; }
        }

        public int Length
        {
            get
            {
                return m_InnerBuilder.Length;
            }
        }

        public void Remove(int startIndex, int length)
        {
            m_InnerBuilder.Remove(startIndex, length);
        }

        public void Replace(string oldValue, string newValue)
        {
            m_InnerBuilder.Replace(oldValue, newValue);
        }

        public StringBuffer()
        {
            m_InnerBuilder = new StringBuilder();
        }

        public StringBuffer(int capacity)
        {
            m_InnerBuilder = new StringBuilder(capacity);
        }

        public StringBuffer(string value)
        {
            m_InnerBuilder = new StringBuilder(value);
        }

        public StringBuffer(int capacity, int maxCapacity)
        {
            m_InnerBuilder = new StringBuilder(capacity, maxCapacity);
        }

        public StringBuffer(string value, int capacity)
        {
            m_InnerBuilder = new StringBuilder(value, capacity);
        }

        public StringBuffer(string value, int startIndex, int length, int capacity)
        {
            m_InnerBuilder = new StringBuilder(value, startIndex, length, capacity);
        }

        public StringBuffer(StringBuilder innerBuilder)
        {
            m_InnerBuilder = innerBuilder;
        }

        public static StringBuffer operator +(StringBuffer buffer, bool value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, byte value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, char value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, char[] value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, decimal value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, double value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, float value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, int value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, long value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, object value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, sbyte value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, short value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, string value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, uint value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, ulong value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }
        public static StringBuffer operator +(StringBuffer buffer, ushort value)
        {
            buffer.InnerBuilder.Append(value);

            return buffer;
        }

        public override string ToString()
        {
            return InnerBuilder.ToString();
        }
    }
}
