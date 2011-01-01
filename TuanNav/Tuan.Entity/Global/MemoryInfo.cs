using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace Tuan.Entity.Global
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryInfo
    {
        public uint dwLength;
        /// <summary>
        /// 正在使用的内存(?%)
        /// </summary>
        public uint dwMemoryLoad;
        /// <summary>
        /// 物理内存(单位字节)
        /// </summary>
        public uint dwTotalPhys;
        /// <summary>
        /// 当前程序占用的物理内存
        /// </summary>
        public int dwCurrentMemorySize;
        /// <summary>
        /// 可使用的物理内存(单位字节)
        /// </summary>
        public uint dwAvailPhys;
        /// <summary>
        /// 交换文件总大小(单位字节)
        /// </summary>
        public uint dwTotalPageFile;
        /// <summary>
        /// 尚可交换文件大小(单位字节)
        /// </summary>
        public uint dwAvailPageFile;
        /// <summary>
        /// 总虚拟内存(单位字节)
        /// </summary>
        public uint dwTotalVirtual;
        /// <summary>
        /// 未用虚拟内存(单位字节)
        /// </summary>
        public uint dwAvailVirtual;

        public MemoryInfo GetMemoryInfo()
        {
            MemoryInfo memoryInfo = new MemoryInfo();
            GlobalMemoryStatus(ref memoryInfo);
            System.Diagnostics.Process p = System.Diagnostics.Process.GetCurrentProcess();
            memoryInfo.dwCurrentMemorySize = p.NonpagedSystemMemorySize;
            return memoryInfo;
        }

        [DllImport("kernel32")]
        public static extern void GlobalMemoryStatus(ref  MemoryInfo memoryInfo);
    }
}