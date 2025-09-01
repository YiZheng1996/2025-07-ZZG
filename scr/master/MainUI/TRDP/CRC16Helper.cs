using System;

namespace MainUI.TRDP
{
    /// <summary>
    /// CRC16校验帮助类，与C代码完全兼容
    /// </summary>
    public class CRC16Helper
    {
        /// <summary>
        /// 全局静态实例
        /// </summary>
        public static CRC16Helper Instance { get; } = new CRC16Helper();

        /// <summary>
        /// CRC16查找表
        /// </summary>
        private static readonly ushort[] CRC16_TABLE = [
            0x0000, 0x1021, 0x2042, 0x3063, 0x4084, 0x50A5, 0x60C6, 0x70E7,
            0x8108, 0x9129, 0xA14A, 0xB16B, 0xC18C, 0xD1AD, 0xE1CE, 0xF1EF,
            0x1231, 0x0210, 0x3273, 0x2252, 0x52B5, 0x4294, 0x72F7, 0x62D6,
            0x9339, 0x8318, 0xB37B, 0xA35A, 0xD3BD, 0xC39C, 0xF3FF, 0xE3DE,
            0x2462, 0x3443, 0x0420, 0x1401, 0x64E6, 0x74C7, 0x44A4, 0x5485,
            0xA56A, 0xB54B, 0x8528, 0x9509, 0xE5EE, 0xF5CF, 0xC5AC, 0xD58D,
            0x3653, 0x2672, 0x1611, 0x0630, 0x76D7, 0x66F6, 0x5695, 0x46B4,
            0xB75B, 0xA77A, 0x9719, 0x8738, 0xF7DF, 0xE7FE, 0xD79D, 0xC7BC,
            0x48C4, 0x58E5, 0x6886, 0x78A7, 0x0840, 0x1861, 0x2802, 0x3823,
            0xC9CC, 0xD9ED, 0xE98E, 0xF9AF, 0x8948, 0x9969, 0xA90A, 0xB92B,
            0x5AF5, 0x4AD4, 0x7AB7, 0x6A96, 0x1A71, 0x0A50, 0x3A33, 0x2A12,
            0xDBFD, 0xCBDC, 0xFBBF, 0xEB9E, 0x9B79, 0x8B58, 0xBB3B, 0xAB1A,
            0x6CA6, 0x7C87, 0x4CE4, 0x5CC5, 0x2C22, 0x3C03, 0x0C60, 0x1C41,
            0xEDAE, 0xFD8F, 0xCDEC, 0xDDCD, 0xAD2A, 0xBD0B, 0x8D68, 0x9D49,
            0x7E97, 0x6EB6, 0x5ED5, 0x4EF4, 0x3E13, 0x2E32, 0x1E51, 0x0E70,
            0xFF9F, 0xEFBE, 0xDFDD, 0xCFFC, 0xBF1B, 0xAF3A, 0x9F59, 0x8F78,
            0x9188, 0x81A9, 0xB1CA, 0xA1EB, 0xD10C, 0xC12D, 0xF14E, 0xE16F,
            0x1080, 0x00A1, 0x30C2, 0x20E3, 0x5004, 0x4025, 0x7046, 0x6067,
            0x83B9, 0x9398, 0xA3FB, 0xB3DA, 0xC33D, 0xD31C, 0xE37F, 0xF35E,
            0x02B1, 0x1290, 0x22F3, 0x32D2, 0x4235, 0x5214, 0x6277, 0x7256,
            0xB5EA, 0xA5CB, 0x95A8, 0x8589, 0xF56E, 0xE54F, 0xD52C, 0xC50D,
            0x34E2, 0x24C3, 0x14A0, 0x0481, 0x7466, 0x6447, 0x5424, 0x4405,
            0xA7DB, 0xB7FA, 0x8799, 0x97B8, 0xE75F, 0xF77E, 0xC71D, 0xD73C,
            0x26D3, 0x36F2, 0x0691, 0x16B0, 0x6657, 0x7676, 0x4615, 0x5634,
            0xD94C, 0xC96D, 0xF90E, 0xE92F, 0x99C8, 0x89E9, 0xB98A, 0xA9AB,
            0x5844, 0x4865, 0x7806, 0x6827, 0x18C0, 0x08E1, 0x3882, 0x28A3,
            0xCB7D, 0xDB5C, 0xEB3F, 0xFB1E, 0x8BF9, 0x9BD8, 0xABBB, 0xBB9A,
            0x4A75, 0x5A54, 0x6A37, 0x7A16, 0x0AF1, 0x1AD0, 0x2AB3, 0x3A92,
            0xFD2E, 0xED0F, 0xDD6C, 0xCD4D, 0xBDAA, 0xAD8B, 0x9DE8, 0x8DC9,
            0x7C26, 0x6C07, 0x5C64, 0x4C45, 0x3CA2, 0x2C83, 0x1CE0, 0x0CC1,
            0xEF1F, 0xFF3E, 0xCF5D, 0xDF7C, 0xAF9B, 0xBFBA, 0x8FD9, 0x9FF8,
            0x6E17, 0x7E36, 0x4E55, 0x5E74, 0x2E93, 0x3EB2, 0x0ED1, 0x1EF0
        ];

        /// <summary>
        /// CRC16初始值常量
        /// </summary>
        private const ushort INITIAL_VALUE = 0xFFFF;

        /// <summary>
        /// 构造函数
        /// </summary>
        public CRC16Helper() { }

        /// <summary>
        /// 计算CRC16校验值
        /// </summary>
        /// <param name="data">数据源</param>
        /// <param name="startIndex">起始索引</param>
        /// <param name="length">计算长度</param>
        /// <param name="initialValue">CRC初始值，默认为0xFFFF</param>
        /// <returns>CRC16校验值</returns>
        public ushort ComputeChecksum(byte[] data, int startIndex, int length, ushort initialValue = INITIAL_VALUE)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));
            if (startIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "起始索引不能为负数");
            if (length < 0)
                throw new ArgumentOutOfRangeException(nameof(length), "长度不能为负数");
            if (startIndex + length > data.Length)
                throw new ArgumentException("起始索引加长度超出数据范围");

            ushort crc = initialValue;

            for (int i = startIndex; i < startIndex + length; i++)
            {
                byte tableIndex = (byte)(((crc >> 8) ^ data[i]) & 0xFF);
                crc = (ushort)((crc << 8) ^ CRC16_TABLE[tableIndex]);
            }

            return crc;
        }

        /// <summary>
        /// 计算整个数组的CRC16校验值
        /// </summary>
        /// <param name="data">待校验的数据</param>
        /// <param name="initialValue">CRC初始值，默认为0xFFFF</param>
        /// <returns>CRC16校验值</returns>
        public ushort ComputeChecksum(byte[] data, ushort initialValue = INITIAL_VALUE)
        {
            if (data == null)
                return 0;

            return ComputeChecksum(data, 0, data.Length, initialValue);
        }

        /// <summary>
        /// 计算指定范围内数据的CRC16校验值字节数组
        /// </summary>
        /// <param name="data">数据源</param>
        /// <param name="startIndex">起始索引</param>
        /// <param name="endIndex">结束索引（不包含）</param>
        /// <param name="highByteFirst">是否高字节在前，默认true</param>
        /// <returns>CRC16校验值的字节数组</returns>
        public byte[] CRC16(byte[] data, int startIndex, int endIndex, bool highByteFirst = true)
        {
            if (data == null || startIndex < 0 || endIndex <= startIndex || endIndex > data.Length)
                return new byte[2];

            int length = endIndex - startIndex;
            ushort crc = ComputeChecksum(data, startIndex, length);

            return ConvertToBytes(crc, highByteFirst);
        }

        /// <summary>
        /// 计算指定范围内数据的CRC16校验值字节数组（保持原接口兼容性）
        /// </summary>
        /// <param name="data">数据源</param>
        /// <param name="startIndex">起始索引</param>
        /// <param name="endIndex">结束索引（不包含）</param>
        /// <param name="algorithm">算法类型（已废弃，保持兼容性）</param>
        /// <param name="reverseBytes">是否反转字节序（低字节在前）</param>
        /// <returns>CRC16校验值的字节数组</returns>
        [Obsolete("algorithm参数已废弃，请使用CRC16(byte[], int, int, bool)方法")]
        public byte[] CRC16(byte[] data, int startIndex, int endIndex,
            CRC16Algorithm algorithm, bool reverseBytes = false)
        {
            return CRC16(data, startIndex, endIndex, !reverseBytes);
        }

        /// <summary>
        /// 验证数据的CRC校验值是否正确
        /// </summary>
        /// <param name="data">原始数据（不包含CRC）</param>
        /// <param name="expectedCrc">期望的CRC值</param>
        /// <param name="initialValue">CRC初始值，默认为0xFFFF</param>
        /// <returns>校验是否通过</returns>
        public bool VerifyChecksum(byte[] data, ushort expectedCrc, ushort initialValue = INITIAL_VALUE)
        {
            return ComputeChecksum(data, initialValue) == expectedCrc;
        }

        /// <summary>
        /// 验证带CRC的完整数据包
        /// </summary>
        /// <param name="dataWithCrc">包含CRC的完整数据包</param>
        /// <param name="crcLength">CRC字节长度（通常为2）</param>
        /// <param name="highByteFirst">CRC是否高字节在前</param>
        /// <param name="initialValue">CRC初始值，默认为0xFFFF</param>
        /// <returns>校验是否通过</returns>
        public bool VerifyDataWithCrc(byte[] dataWithCrc, int crcLength = 2,
            bool highByteFirst = true, ushort initialValue = INITIAL_VALUE)
        {
            if (dataWithCrc == null || dataWithCrc.Length < crcLength)
                return false;

            int dataLength = dataWithCrc.Length - crcLength;
            ushort calculatedCrc = ComputeChecksum(dataWithCrc, 0, dataLength, initialValue);

            // 提取CRC值
            ushort expectedCrc;
            if (highByteFirst)
            {
                expectedCrc = (ushort)((dataWithCrc[dataLength] << 8) | dataWithCrc[dataLength + 1]);
            }
            else
            {
                expectedCrc = (ushort)((dataWithCrc[dataLength + 1] << 8) | dataWithCrc[dataLength]);
            }

            return calculatedCrc == expectedCrc;
        }

        /// <summary>
        /// 为数据添加CRC16校验值
        /// </summary>
        /// <param name="data">原始数据</param>
        /// <param name="highByteFirst">是否高字节在前，默认true</param>
        /// <param name="initialValue">CRC初始值，默认为0xFFFF</param>
        /// <returns>包含CRC校验值的完整数据</returns>
        public byte[] AddCRC16(byte[] data, bool highByteFirst = true, ushort initialValue = INITIAL_VALUE)
        {
            ArgumentNullException.ThrowIfNull(data);

            ushort crc = ComputeChecksum(data, initialValue);
            byte[] result = new byte[data.Length + 2];

            Array.Copy(data, result, data.Length);
            byte[] crcBytes = ConvertToBytes(crc, highByteFirst);
            result[data.Length] = crcBytes[0];
            result[data.Length + 1] = crcBytes[1];

            return result;
        }

        /// <summary>
        /// 将CRC值转换为字节数组
        /// </summary>
        /// <param name="crc">CRC值</param>
        /// <param name="highByteFirst">是否高字节在前</param>
        /// <returns>字节数组</returns>
        private static byte[] ConvertToBytes(ushort crc, bool highByteFirst)
        {
            byte[] result = new byte[2];
            if (highByteFirst)
            {
                result[0] = (byte)(crc >> 8);     // 高字节
                result[1] = (byte)(crc & 0xFF);   // 低字节
            }
            else
            {
                result[0] = (byte)(crc & 0xFF);   // 低字节
                result[1] = (byte)(crc >> 8);     // 高字节
            }
            return result;
        }

        /// <summary>
        /// 获取CRC16查找表的副本（用于调试和验证）
        /// </summary>
        /// <returns>CRC16查找表副本</returns>
        public ushort[] GetCRCTable()
        {
            ushort[] tableCopy = new ushort[CRC16_TABLE.Length];
            Array.Copy(CRC16_TABLE, tableCopy, CRC16_TABLE.Length);
            return tableCopy;
        }

        /// <summary>
        /// 获取查找表的十六进制字符串表示（用于调试）
        /// </summary>
        /// <returns>查找表的十六进制字符串</returns>
        public string GetTableHexString()
        {
            System.Text.StringBuilder sb = new();
            for (int i = 0; i < CRC16_TABLE.Length; i++)
            {
                if (i % 8 == 0 && i > 0)
                    sb.AppendLine();
                sb.AppendFormat("0x{0:X4}", CRC16_TABLE[i]);
                if (i < CRC16_TABLE.Length - 1)
                    sb.Append(", ");
            }
            return sb.ToString();
        }
    }

    /// <summary>
    /// 廖翔发CRC校验类
    /// </summary>
    public class CRC16_FALSEHelper
    {
        public static CRC16_FALSEHelper Instance { get; } = new CRC16_FALSEHelper();

        private const ushort polynomial = 0x1021;
        private ushort[] table = new ushort[256];
        private ushort initialValue = 0xFFFF;

        public CRC16_FALSEHelper()
        {
            GenerateTable();
        }

        private void GenerateTable()
        {
            for (ushort i = 0; i < table.Length; ++i)
            {
                ushort value = 0;
                ushort temp = (ushort)(i << 8);
                for (byte j = 0; j < 8; ++j)
                {
                    if (((value ^ temp) & 0x8000) != 0)
                    {
                        value = (ushort)((value << 1) ^ polynomial);
                    }
                    else
                    {
                        value <<= 1;
                    }
                    temp <<= 1;
                }
                table[i] = value;
            }
        }

        public ushort ComputeChecksum(byte[] bytes)
        {

            ushort crc = initialValue;
            foreach (byte b in bytes)
            {
                byte index = (byte)((crc >> 8) ^ b);
                crc = (ushort)((crc << 8) ^ table[index]);
            }
            return crc;
        }
        public byte[] ComputeChecksumBytes(byte[] bytes)
        {
            ushort crc = ComputeChecksum(bytes);
            return BitConverter.GetBytes(crc);
        }
        public byte[] CRC16(byte[] data, int fromIndex, int endIndex)
        {
            byte[] temp = new byte[endIndex - fromIndex];
            Array.Copy(data, fromIndex, temp, 0, endIndex - fromIndex);


            return ComputeChecksumBytes(temp);
        }
    }

    /// <summary>
    /// CRC16校验算法类型枚举（保持向后兼容性，实际已统一使用同一算法）
    /// </summary>
    [Obsolete("CRC16算法已统一，此枚举仅保持向后兼容性")]
    public enum CRC16Algorithm
    {
        /// <summary>
        /// CRC16标准算法（多项式：0x1021，初始值：0xFFFF）
        /// </summary>
        CCITT,
        /// <summary>
        /// CRC16标准算法（多项式：0x1021，初始值：0xFFFF）
        /// </summary>
        CCITT_False
    }
}