﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BarcodeStandard;

namespace BarcodeStandardTests.Symbologies
{
    [TestClass]
    public class Code93Tests
    {
        private readonly Barcode _barcode = new Barcode
        {
            EncodedType = Type.Code93,
        };

        [DataTestMethod]
        [DataRow("038000356216", "1010111101000101001010000101000100101000101001000101001000101001010000101001001001001000101010001001010010001001000101001000101001100101010111101")]
        [DataRow("123456789012", "1010111101010010001010001001010000101001010001001001001001000101010100001000100101000010101000101001010010001010001001010011001110101101010111101")]
        [DataRow("192794729478", "1010111101010010001000010101010001001010100001000010101001010001010100001010001001000010101001010001010100001000100101011011101000100101010111101")]
        public void EncodeBarcode(
            string data,
            string expected)
        {
            _barcode.Encode(data);
            Assert.AreEqual(expected, _barcode.EncodedValue, $"{_barcode.EncodedType}");
        }
    }
}
