﻿
using System;
using LangExt;
using NUnit.Framework;
using Microsoft.CSharp.RuntimeBinder;

namespace LangExt.Tests
{
    [TestFixture]
    public class SeqZipTest
    {
        [Test]
        public void Seq_Zip()
        {
            var xs2_1 = Seq.Repeat(10, 1);
            var xs2_2 = Seq.Repeat(10, 2);
            var zipped2 = Seq.Zip(xs2_1, xs2_2);
            Assert.That(zipped2.Unzip()._1(), Is.EqualTo(xs2_1));
            Assert.That(zipped2.Unzip()._2(), Is.EqualTo(xs2_2));
            Assert.That(Seq.ZipWith(xs2_1, xs2_2, Create.Tuple), Is.EqualTo(zipped2));

            var xs3_1 = Seq.Repeat(10, 1);
            var xs3_2 = Seq.Repeat(10, 2);
            var xs3_3 = Seq.Repeat(10, 3);
            var zipped3 = Seq.Zip(xs3_1, xs3_2, xs3_3);
            Assert.That(zipped3.Unzip()._1(), Is.EqualTo(xs3_1));
            Assert.That(zipped3.Unzip()._2(), Is.EqualTo(xs3_2));
            Assert.That(zipped3.Unzip()._3(), Is.EqualTo(xs3_3));
            Assert.That(Seq.ZipWith(xs3_1, xs3_2, xs3_3, Create.Tuple), Is.EqualTo(zipped3));

            var xs4_1 = Seq.Repeat(10, 1);
            var xs4_2 = Seq.Repeat(10, 2);
            var xs4_3 = Seq.Repeat(10, 3);
            var xs4_4 = Seq.Repeat(10, 4);
            var zipped4 = Seq.Zip(xs4_1, xs4_2, xs4_3, xs4_4);
            Assert.That(zipped4.Unzip()._1(), Is.EqualTo(xs4_1));
            Assert.That(zipped4.Unzip()._2(), Is.EqualTo(xs4_2));
            Assert.That(zipped4.Unzip()._3(), Is.EqualTo(xs4_3));
            Assert.That(zipped4.Unzip()._4(), Is.EqualTo(xs4_4));
            Assert.That(Seq.ZipWith(xs4_1, xs4_2, xs4_3, xs4_4, Create.Tuple), Is.EqualTo(zipped4));

            var xs5_1 = Seq.Repeat(10, 1);
            var xs5_2 = Seq.Repeat(10, 2);
            var xs5_3 = Seq.Repeat(10, 3);
            var xs5_4 = Seq.Repeat(10, 4);
            var xs5_5 = Seq.Repeat(10, 5);
            var zipped5 = Seq.Zip(xs5_1, xs5_2, xs5_3, xs5_4, xs5_5);
            Assert.That(zipped5.Unzip()._1(), Is.EqualTo(xs5_1));
            Assert.That(zipped5.Unzip()._2(), Is.EqualTo(xs5_2));
            Assert.That(zipped5.Unzip()._3(), Is.EqualTo(xs5_3));
            Assert.That(zipped5.Unzip()._4(), Is.EqualTo(xs5_4));
            Assert.That(zipped5.Unzip()._5(), Is.EqualTo(xs5_5));
            Assert.That(Seq.ZipWith(xs5_1, xs5_2, xs5_3, xs5_4, xs5_5, Create.Tuple), Is.EqualTo(zipped5));

            var xs6_1 = Seq.Repeat(10, 1);
            var xs6_2 = Seq.Repeat(10, 2);
            var xs6_3 = Seq.Repeat(10, 3);
            var xs6_4 = Seq.Repeat(10, 4);
            var xs6_5 = Seq.Repeat(10, 5);
            var xs6_6 = Seq.Repeat(10, 6);
            var zipped6 = Seq.Zip(xs6_1, xs6_2, xs6_3, xs6_4, xs6_5, xs6_6);
            Assert.That(zipped6.Unzip()._1(), Is.EqualTo(xs6_1));
            Assert.That(zipped6.Unzip()._2(), Is.EqualTo(xs6_2));
            Assert.That(zipped6.Unzip()._3(), Is.EqualTo(xs6_3));
            Assert.That(zipped6.Unzip()._4(), Is.EqualTo(xs6_4));
            Assert.That(zipped6.Unzip()._5(), Is.EqualTo(xs6_5));
            Assert.That(zipped6.Unzip()._6(), Is.EqualTo(xs6_6));
            Assert.That(Seq.ZipWith(xs6_1, xs6_2, xs6_3, xs6_4, xs6_5, xs6_6, Create.Tuple), Is.EqualTo(zipped6));

            var xs7_1 = Seq.Repeat(10, 1);
            var xs7_2 = Seq.Repeat(10, 2);
            var xs7_3 = Seq.Repeat(10, 3);
            var xs7_4 = Seq.Repeat(10, 4);
            var xs7_5 = Seq.Repeat(10, 5);
            var xs7_6 = Seq.Repeat(10, 6);
            var xs7_7 = Seq.Repeat(10, 7);
            var zipped7 = Seq.Zip(xs7_1, xs7_2, xs7_3, xs7_4, xs7_5, xs7_6, xs7_7);
            Assert.That(zipped7.Unzip()._1(), Is.EqualTo(xs7_1));
            Assert.That(zipped7.Unzip()._2(), Is.EqualTo(xs7_2));
            Assert.That(zipped7.Unzip()._3(), Is.EqualTo(xs7_3));
            Assert.That(zipped7.Unzip()._4(), Is.EqualTo(xs7_4));
            Assert.That(zipped7.Unzip()._5(), Is.EqualTo(xs7_5));
            Assert.That(zipped7.Unzip()._6(), Is.EqualTo(xs7_6));
            Assert.That(zipped7.Unzip()._7(), Is.EqualTo(xs7_7));
            Assert.That(Seq.ZipWith(xs7_1, xs7_2, xs7_3, xs7_4, xs7_5, xs7_6, xs7_7, Create.Tuple), Is.EqualTo(zipped7));

            var xs8_1 = Seq.Repeat(10, 1);
            var xs8_2 = Seq.Repeat(10, 2);
            var xs8_3 = Seq.Repeat(10, 3);
            var xs8_4 = Seq.Repeat(10, 4);
            var xs8_5 = Seq.Repeat(10, 5);
            var xs8_6 = Seq.Repeat(10, 6);
            var xs8_7 = Seq.Repeat(10, 7);
            var xs8_8 = Seq.Repeat(10, 8);
            var zipped8 = Seq.Zip(xs8_1, xs8_2, xs8_3, xs8_4, xs8_5, xs8_6, xs8_7, xs8_8);
            Assert.That(zipped8.Unzip()._1(), Is.EqualTo(xs8_1));
            Assert.That(zipped8.Unzip()._2(), Is.EqualTo(xs8_2));
            Assert.That(zipped8.Unzip()._3(), Is.EqualTo(xs8_3));
            Assert.That(zipped8.Unzip()._4(), Is.EqualTo(xs8_4));
            Assert.That(zipped8.Unzip()._5(), Is.EqualTo(xs8_5));
            Assert.That(zipped8.Unzip()._6(), Is.EqualTo(xs8_6));
            Assert.That(zipped8.Unzip()._7(), Is.EqualTo(xs8_7));
            Assert.That(zipped8.Unzip()._8(), Is.EqualTo(xs8_8));
            Assert.That(Seq.ZipWith(xs8_1, xs8_2, xs8_3, xs8_4, xs8_5, xs8_6, xs8_7, xs8_8, Create.Tuple), Is.EqualTo(zipped8));

            var xs9_1 = Seq.Repeat(10, 1);
            var xs9_2 = Seq.Repeat(10, 2);
            var xs9_3 = Seq.Repeat(10, 3);
            var xs9_4 = Seq.Repeat(10, 4);
            var xs9_5 = Seq.Repeat(10, 5);
            var xs9_6 = Seq.Repeat(10, 6);
            var xs9_7 = Seq.Repeat(10, 7);
            var xs9_8 = Seq.Repeat(10, 8);
            var xs9_9 = Seq.Repeat(10, 9);
            var zipped9 = Seq.Zip(xs9_1, xs9_2, xs9_3, xs9_4, xs9_5, xs9_6, xs9_7, xs9_8, xs9_9);
            Assert.That(zipped9.Unzip()._1(), Is.EqualTo(xs9_1));
            Assert.That(zipped9.Unzip()._2(), Is.EqualTo(xs9_2));
            Assert.That(zipped9.Unzip()._3(), Is.EqualTo(xs9_3));
            Assert.That(zipped9.Unzip()._4(), Is.EqualTo(xs9_4));
            Assert.That(zipped9.Unzip()._5(), Is.EqualTo(xs9_5));
            Assert.That(zipped9.Unzip()._6(), Is.EqualTo(xs9_6));
            Assert.That(zipped9.Unzip()._7(), Is.EqualTo(xs9_7));
            Assert.That(zipped9.Unzip()._8(), Is.EqualTo(xs9_8));
            Assert.That(zipped9.Unzip()._9(), Is.EqualTo(xs9_9));
            Assert.That(Seq.ZipWith(xs9_1, xs9_2, xs9_3, xs9_4, xs9_5, xs9_6, xs9_7, xs9_8, xs9_9, Create.Tuple), Is.EqualTo(zipped9));

            var xs10_1 = Seq.Repeat(10, 1);
            var xs10_2 = Seq.Repeat(10, 2);
            var xs10_3 = Seq.Repeat(10, 3);
            var xs10_4 = Seq.Repeat(10, 4);
            var xs10_5 = Seq.Repeat(10, 5);
            var xs10_6 = Seq.Repeat(10, 6);
            var xs10_7 = Seq.Repeat(10, 7);
            var xs10_8 = Seq.Repeat(10, 8);
            var xs10_9 = Seq.Repeat(10, 9);
            var xs10_10 = Seq.Repeat(10, 10);
            var zipped10 = Seq.Zip(xs10_1, xs10_2, xs10_3, xs10_4, xs10_5, xs10_6, xs10_7, xs10_8, xs10_9, xs10_10);
            Assert.That(zipped10.Unzip()._1(), Is.EqualTo(xs10_1));
            Assert.That(zipped10.Unzip()._2(), Is.EqualTo(xs10_2));
            Assert.That(zipped10.Unzip()._3(), Is.EqualTo(xs10_3));
            Assert.That(zipped10.Unzip()._4(), Is.EqualTo(xs10_4));
            Assert.That(zipped10.Unzip()._5(), Is.EqualTo(xs10_5));
            Assert.That(zipped10.Unzip()._6(), Is.EqualTo(xs10_6));
            Assert.That(zipped10.Unzip()._7(), Is.EqualTo(xs10_7));
            Assert.That(zipped10.Unzip()._8(), Is.EqualTo(xs10_8));
            Assert.That(zipped10.Unzip()._9(), Is.EqualTo(xs10_9));
            Assert.That(zipped10.Unzip()._10(), Is.EqualTo(xs10_10));
            Assert.That(Seq.ZipWith(xs10_1, xs10_2, xs10_3, xs10_4, xs10_5, xs10_6, xs10_7, xs10_8, xs10_9, xs10_10, Create.Tuple), Is.EqualTo(zipped10));

            var xs11_1 = Seq.Repeat(10, 1);
            var xs11_2 = Seq.Repeat(10, 2);
            var xs11_3 = Seq.Repeat(10, 3);
            var xs11_4 = Seq.Repeat(10, 4);
            var xs11_5 = Seq.Repeat(10, 5);
            var xs11_6 = Seq.Repeat(10, 6);
            var xs11_7 = Seq.Repeat(10, 7);
            var xs11_8 = Seq.Repeat(10, 8);
            var xs11_9 = Seq.Repeat(10, 9);
            var xs11_10 = Seq.Repeat(10, 10);
            var xs11_11 = Seq.Repeat(10, 11);
            var zipped11 = Seq.Zip(xs11_1, xs11_2, xs11_3, xs11_4, xs11_5, xs11_6, xs11_7, xs11_8, xs11_9, xs11_10, xs11_11);
            Assert.That(zipped11.Unzip()._1(), Is.EqualTo(xs11_1));
            Assert.That(zipped11.Unzip()._2(), Is.EqualTo(xs11_2));
            Assert.That(zipped11.Unzip()._3(), Is.EqualTo(xs11_3));
            Assert.That(zipped11.Unzip()._4(), Is.EqualTo(xs11_4));
            Assert.That(zipped11.Unzip()._5(), Is.EqualTo(xs11_5));
            Assert.That(zipped11.Unzip()._6(), Is.EqualTo(xs11_6));
            Assert.That(zipped11.Unzip()._7(), Is.EqualTo(xs11_7));
            Assert.That(zipped11.Unzip()._8(), Is.EqualTo(xs11_8));
            Assert.That(zipped11.Unzip()._9(), Is.EqualTo(xs11_9));
            Assert.That(zipped11.Unzip()._10(), Is.EqualTo(xs11_10));
            Assert.That(zipped11.Unzip()._11(), Is.EqualTo(xs11_11));
            Assert.That(Seq.ZipWith(xs11_1, xs11_2, xs11_3, xs11_4, xs11_5, xs11_6, xs11_7, xs11_8, xs11_9, xs11_10, xs11_11, Create.Tuple), Is.EqualTo(zipped11));

            var xs12_1 = Seq.Repeat(10, 1);
            var xs12_2 = Seq.Repeat(10, 2);
            var xs12_3 = Seq.Repeat(10, 3);
            var xs12_4 = Seq.Repeat(10, 4);
            var xs12_5 = Seq.Repeat(10, 5);
            var xs12_6 = Seq.Repeat(10, 6);
            var xs12_7 = Seq.Repeat(10, 7);
            var xs12_8 = Seq.Repeat(10, 8);
            var xs12_9 = Seq.Repeat(10, 9);
            var xs12_10 = Seq.Repeat(10, 10);
            var xs12_11 = Seq.Repeat(10, 11);
            var xs12_12 = Seq.Repeat(10, 12);
            var zipped12 = Seq.Zip(xs12_1, xs12_2, xs12_3, xs12_4, xs12_5, xs12_6, xs12_7, xs12_8, xs12_9, xs12_10, xs12_11, xs12_12);
            Assert.That(zipped12.Unzip()._1(), Is.EqualTo(xs12_1));
            Assert.That(zipped12.Unzip()._2(), Is.EqualTo(xs12_2));
            Assert.That(zipped12.Unzip()._3(), Is.EqualTo(xs12_3));
            Assert.That(zipped12.Unzip()._4(), Is.EqualTo(xs12_4));
            Assert.That(zipped12.Unzip()._5(), Is.EqualTo(xs12_5));
            Assert.That(zipped12.Unzip()._6(), Is.EqualTo(xs12_6));
            Assert.That(zipped12.Unzip()._7(), Is.EqualTo(xs12_7));
            Assert.That(zipped12.Unzip()._8(), Is.EqualTo(xs12_8));
            Assert.That(zipped12.Unzip()._9(), Is.EqualTo(xs12_9));
            Assert.That(zipped12.Unzip()._10(), Is.EqualTo(xs12_10));
            Assert.That(zipped12.Unzip()._11(), Is.EqualTo(xs12_11));
            Assert.That(zipped12.Unzip()._12(), Is.EqualTo(xs12_12));
            Assert.That(Seq.ZipWith(xs12_1, xs12_2, xs12_3, xs12_4, xs12_5, xs12_6, xs12_7, xs12_8, xs12_9, xs12_10, xs12_11, xs12_12, Create.Tuple), Is.EqualTo(zipped12));

            var xs13_1 = Seq.Repeat(10, 1);
            var xs13_2 = Seq.Repeat(10, 2);
            var xs13_3 = Seq.Repeat(10, 3);
            var xs13_4 = Seq.Repeat(10, 4);
            var xs13_5 = Seq.Repeat(10, 5);
            var xs13_6 = Seq.Repeat(10, 6);
            var xs13_7 = Seq.Repeat(10, 7);
            var xs13_8 = Seq.Repeat(10, 8);
            var xs13_9 = Seq.Repeat(10, 9);
            var xs13_10 = Seq.Repeat(10, 10);
            var xs13_11 = Seq.Repeat(10, 11);
            var xs13_12 = Seq.Repeat(10, 12);
            var xs13_13 = Seq.Repeat(10, 13);
            var zipped13 = Seq.Zip(xs13_1, xs13_2, xs13_3, xs13_4, xs13_5, xs13_6, xs13_7, xs13_8, xs13_9, xs13_10, xs13_11, xs13_12, xs13_13);
            Assert.That(zipped13.Unzip()._1(), Is.EqualTo(xs13_1));
            Assert.That(zipped13.Unzip()._2(), Is.EqualTo(xs13_2));
            Assert.That(zipped13.Unzip()._3(), Is.EqualTo(xs13_3));
            Assert.That(zipped13.Unzip()._4(), Is.EqualTo(xs13_4));
            Assert.That(zipped13.Unzip()._5(), Is.EqualTo(xs13_5));
            Assert.That(zipped13.Unzip()._6(), Is.EqualTo(xs13_6));
            Assert.That(zipped13.Unzip()._7(), Is.EqualTo(xs13_7));
            Assert.That(zipped13.Unzip()._8(), Is.EqualTo(xs13_8));
            Assert.That(zipped13.Unzip()._9(), Is.EqualTo(xs13_9));
            Assert.That(zipped13.Unzip()._10(), Is.EqualTo(xs13_10));
            Assert.That(zipped13.Unzip()._11(), Is.EqualTo(xs13_11));
            Assert.That(zipped13.Unzip()._12(), Is.EqualTo(xs13_12));
            Assert.That(zipped13.Unzip()._13(), Is.EqualTo(xs13_13));
            Assert.That(Seq.ZipWith(xs13_1, xs13_2, xs13_3, xs13_4, xs13_5, xs13_6, xs13_7, xs13_8, xs13_9, xs13_10, xs13_11, xs13_12, xs13_13, Create.Tuple), Is.EqualTo(zipped13));

            var xs14_1 = Seq.Repeat(10, 1);
            var xs14_2 = Seq.Repeat(10, 2);
            var xs14_3 = Seq.Repeat(10, 3);
            var xs14_4 = Seq.Repeat(10, 4);
            var xs14_5 = Seq.Repeat(10, 5);
            var xs14_6 = Seq.Repeat(10, 6);
            var xs14_7 = Seq.Repeat(10, 7);
            var xs14_8 = Seq.Repeat(10, 8);
            var xs14_9 = Seq.Repeat(10, 9);
            var xs14_10 = Seq.Repeat(10, 10);
            var xs14_11 = Seq.Repeat(10, 11);
            var xs14_12 = Seq.Repeat(10, 12);
            var xs14_13 = Seq.Repeat(10, 13);
            var xs14_14 = Seq.Repeat(10, 14);
            var zipped14 = Seq.Zip(xs14_1, xs14_2, xs14_3, xs14_4, xs14_5, xs14_6, xs14_7, xs14_8, xs14_9, xs14_10, xs14_11, xs14_12, xs14_13, xs14_14);
            Assert.That(zipped14.Unzip()._1(), Is.EqualTo(xs14_1));
            Assert.That(zipped14.Unzip()._2(), Is.EqualTo(xs14_2));
            Assert.That(zipped14.Unzip()._3(), Is.EqualTo(xs14_3));
            Assert.That(zipped14.Unzip()._4(), Is.EqualTo(xs14_4));
            Assert.That(zipped14.Unzip()._5(), Is.EqualTo(xs14_5));
            Assert.That(zipped14.Unzip()._6(), Is.EqualTo(xs14_6));
            Assert.That(zipped14.Unzip()._7(), Is.EqualTo(xs14_7));
            Assert.That(zipped14.Unzip()._8(), Is.EqualTo(xs14_8));
            Assert.That(zipped14.Unzip()._9(), Is.EqualTo(xs14_9));
            Assert.That(zipped14.Unzip()._10(), Is.EqualTo(xs14_10));
            Assert.That(zipped14.Unzip()._11(), Is.EqualTo(xs14_11));
            Assert.That(zipped14.Unzip()._12(), Is.EqualTo(xs14_12));
            Assert.That(zipped14.Unzip()._13(), Is.EqualTo(xs14_13));
            Assert.That(zipped14.Unzip()._14(), Is.EqualTo(xs14_14));
            Assert.That(Seq.ZipWith(xs14_1, xs14_2, xs14_3, xs14_4, xs14_5, xs14_6, xs14_7, xs14_8, xs14_9, xs14_10, xs14_11, xs14_12, xs14_13, xs14_14, Create.Tuple), Is.EqualTo(zipped14));

            var xs15_1 = Seq.Repeat(10, 1);
            var xs15_2 = Seq.Repeat(10, 2);
            var xs15_3 = Seq.Repeat(10, 3);
            var xs15_4 = Seq.Repeat(10, 4);
            var xs15_5 = Seq.Repeat(10, 5);
            var xs15_6 = Seq.Repeat(10, 6);
            var xs15_7 = Seq.Repeat(10, 7);
            var xs15_8 = Seq.Repeat(10, 8);
            var xs15_9 = Seq.Repeat(10, 9);
            var xs15_10 = Seq.Repeat(10, 10);
            var xs15_11 = Seq.Repeat(10, 11);
            var xs15_12 = Seq.Repeat(10, 12);
            var xs15_13 = Seq.Repeat(10, 13);
            var xs15_14 = Seq.Repeat(10, 14);
            var xs15_15 = Seq.Repeat(10, 15);
            var zipped15 = Seq.Zip(xs15_1, xs15_2, xs15_3, xs15_4, xs15_5, xs15_6, xs15_7, xs15_8, xs15_9, xs15_10, xs15_11, xs15_12, xs15_13, xs15_14, xs15_15);
            Assert.That(zipped15.Unzip()._1(), Is.EqualTo(xs15_1));
            Assert.That(zipped15.Unzip()._2(), Is.EqualTo(xs15_2));
            Assert.That(zipped15.Unzip()._3(), Is.EqualTo(xs15_3));
            Assert.That(zipped15.Unzip()._4(), Is.EqualTo(xs15_4));
            Assert.That(zipped15.Unzip()._5(), Is.EqualTo(xs15_5));
            Assert.That(zipped15.Unzip()._6(), Is.EqualTo(xs15_6));
            Assert.That(zipped15.Unzip()._7(), Is.EqualTo(xs15_7));
            Assert.That(zipped15.Unzip()._8(), Is.EqualTo(xs15_8));
            Assert.That(zipped15.Unzip()._9(), Is.EqualTo(xs15_9));
            Assert.That(zipped15.Unzip()._10(), Is.EqualTo(xs15_10));
            Assert.That(zipped15.Unzip()._11(), Is.EqualTo(xs15_11));
            Assert.That(zipped15.Unzip()._12(), Is.EqualTo(xs15_12));
            Assert.That(zipped15.Unzip()._13(), Is.EqualTo(xs15_13));
            Assert.That(zipped15.Unzip()._14(), Is.EqualTo(xs15_14));
            Assert.That(zipped15.Unzip()._15(), Is.EqualTo(xs15_15));
            Assert.That(Seq.ZipWith(xs15_1, xs15_2, xs15_3, xs15_4, xs15_5, xs15_6, xs15_7, xs15_8, xs15_9, xs15_10, xs15_11, xs15_12, xs15_13, xs15_14, xs15_15, Create.Tuple), Is.EqualTo(zipped15));

            var xs16_1 = Seq.Repeat(10, 1);
            var xs16_2 = Seq.Repeat(10, 2);
            var xs16_3 = Seq.Repeat(10, 3);
            var xs16_4 = Seq.Repeat(10, 4);
            var xs16_5 = Seq.Repeat(10, 5);
            var xs16_6 = Seq.Repeat(10, 6);
            var xs16_7 = Seq.Repeat(10, 7);
            var xs16_8 = Seq.Repeat(10, 8);
            var xs16_9 = Seq.Repeat(10, 9);
            var xs16_10 = Seq.Repeat(10, 10);
            var xs16_11 = Seq.Repeat(10, 11);
            var xs16_12 = Seq.Repeat(10, 12);
            var xs16_13 = Seq.Repeat(10, 13);
            var xs16_14 = Seq.Repeat(10, 14);
            var xs16_15 = Seq.Repeat(10, 15);
            var xs16_16 = Seq.Repeat(10, 16);
            var zipped16 = Seq.Zip(xs16_1, xs16_2, xs16_3, xs16_4, xs16_5, xs16_6, xs16_7, xs16_8, xs16_9, xs16_10, xs16_11, xs16_12, xs16_13, xs16_14, xs16_15, xs16_16);
            Assert.That(zipped16.Unzip()._1(), Is.EqualTo(xs16_1));
            Assert.That(zipped16.Unzip()._2(), Is.EqualTo(xs16_2));
            Assert.That(zipped16.Unzip()._3(), Is.EqualTo(xs16_3));
            Assert.That(zipped16.Unzip()._4(), Is.EqualTo(xs16_4));
            Assert.That(zipped16.Unzip()._5(), Is.EqualTo(xs16_5));
            Assert.That(zipped16.Unzip()._6(), Is.EqualTo(xs16_6));
            Assert.That(zipped16.Unzip()._7(), Is.EqualTo(xs16_7));
            Assert.That(zipped16.Unzip()._8(), Is.EqualTo(xs16_8));
            Assert.That(zipped16.Unzip()._9(), Is.EqualTo(xs16_9));
            Assert.That(zipped16.Unzip()._10(), Is.EqualTo(xs16_10));
            Assert.That(zipped16.Unzip()._11(), Is.EqualTo(xs16_11));
            Assert.That(zipped16.Unzip()._12(), Is.EqualTo(xs16_12));
            Assert.That(zipped16.Unzip()._13(), Is.EqualTo(xs16_13));
            Assert.That(zipped16.Unzip()._14(), Is.EqualTo(xs16_14));
            Assert.That(zipped16.Unzip()._15(), Is.EqualTo(xs16_15));
            Assert.That(zipped16.Unzip()._16(), Is.EqualTo(xs16_16));
            Assert.That(Seq.ZipWith(xs16_1, xs16_2, xs16_3, xs16_4, xs16_5, xs16_6, xs16_7, xs16_8, xs16_9, xs16_10, xs16_11, xs16_12, xs16_13, xs16_14, xs16_15, xs16_16, Create.Tuple), Is.EqualTo(zipped16));

        }

        [Test]
        public void Seq_WithIndex()
        {
            var xs = Seq.Repeat(10, 1);
            var res = Seq.WithIndex(xs);
            Assert.That(res, Is.EqualTo(Seq.Zip(xs, Seq.InitInfinite(i => i))));

            var xs2_1 = Seq.Repeat(10, 1);
            var xs2_2 = Seq.Repeat(10, 2);
            var res2 = Seq.WithIndex(Seq.Zip(xs2_1, xs2_2));
            Assert.That(res2, Is.EqualTo(Seq.Zip(xs2_1, xs2_2, Seq.InitInfinite(i => i))));

            var xs3_1 = Seq.Repeat(10, 1);
            var xs3_2 = Seq.Repeat(10, 2);
            var xs3_3 = Seq.Repeat(10, 3);
            var res3 = Seq.WithIndex(Seq.Zip(xs3_1, xs3_2, xs3_3));
            Assert.That(res3, Is.EqualTo(Seq.Zip(xs3_1, xs3_2, xs3_3, Seq.InitInfinite(i => i))));

            var xs4_1 = Seq.Repeat(10, 1);
            var xs4_2 = Seq.Repeat(10, 2);
            var xs4_3 = Seq.Repeat(10, 3);
            var xs4_4 = Seq.Repeat(10, 4);
            var res4 = Seq.WithIndex(Seq.Zip(xs4_1, xs4_2, xs4_3, xs4_4));
            Assert.That(res4, Is.EqualTo(Seq.Zip(xs4_1, xs4_2, xs4_3, xs4_4, Seq.InitInfinite(i => i))));

            var xs5_1 = Seq.Repeat(10, 1);
            var xs5_2 = Seq.Repeat(10, 2);
            var xs5_3 = Seq.Repeat(10, 3);
            var xs5_4 = Seq.Repeat(10, 4);
            var xs5_5 = Seq.Repeat(10, 5);
            var res5 = Seq.WithIndex(Seq.Zip(xs5_1, xs5_2, xs5_3, xs5_4, xs5_5));
            Assert.That(res5, Is.EqualTo(Seq.Zip(xs5_1, xs5_2, xs5_3, xs5_4, xs5_5, Seq.InitInfinite(i => i))));

            var xs6_1 = Seq.Repeat(10, 1);
            var xs6_2 = Seq.Repeat(10, 2);
            var xs6_3 = Seq.Repeat(10, 3);
            var xs6_4 = Seq.Repeat(10, 4);
            var xs6_5 = Seq.Repeat(10, 5);
            var xs6_6 = Seq.Repeat(10, 6);
            var res6 = Seq.WithIndex(Seq.Zip(xs6_1, xs6_2, xs6_3, xs6_4, xs6_5, xs6_6));
            Assert.That(res6, Is.EqualTo(Seq.Zip(xs6_1, xs6_2, xs6_3, xs6_4, xs6_5, xs6_6, Seq.InitInfinite(i => i))));

            var xs7_1 = Seq.Repeat(10, 1);
            var xs7_2 = Seq.Repeat(10, 2);
            var xs7_3 = Seq.Repeat(10, 3);
            var xs7_4 = Seq.Repeat(10, 4);
            var xs7_5 = Seq.Repeat(10, 5);
            var xs7_6 = Seq.Repeat(10, 6);
            var xs7_7 = Seq.Repeat(10, 7);
            var res7 = Seq.WithIndex(Seq.Zip(xs7_1, xs7_2, xs7_3, xs7_4, xs7_5, xs7_6, xs7_7));
            Assert.That(res7, Is.EqualTo(Seq.Zip(xs7_1, xs7_2, xs7_3, xs7_4, xs7_5, xs7_6, xs7_7, Seq.InitInfinite(i => i))));

            var xs8_1 = Seq.Repeat(10, 1);
            var xs8_2 = Seq.Repeat(10, 2);
            var xs8_3 = Seq.Repeat(10, 3);
            var xs8_4 = Seq.Repeat(10, 4);
            var xs8_5 = Seq.Repeat(10, 5);
            var xs8_6 = Seq.Repeat(10, 6);
            var xs8_7 = Seq.Repeat(10, 7);
            var xs8_8 = Seq.Repeat(10, 8);
            var res8 = Seq.WithIndex(Seq.Zip(xs8_1, xs8_2, xs8_3, xs8_4, xs8_5, xs8_6, xs8_7, xs8_8));
            Assert.That(res8, Is.EqualTo(Seq.Zip(xs8_1, xs8_2, xs8_3, xs8_4, xs8_5, xs8_6, xs8_7, xs8_8, Seq.InitInfinite(i => i))));

            var xs9_1 = Seq.Repeat(10, 1);
            var xs9_2 = Seq.Repeat(10, 2);
            var xs9_3 = Seq.Repeat(10, 3);
            var xs9_4 = Seq.Repeat(10, 4);
            var xs9_5 = Seq.Repeat(10, 5);
            var xs9_6 = Seq.Repeat(10, 6);
            var xs9_7 = Seq.Repeat(10, 7);
            var xs9_8 = Seq.Repeat(10, 8);
            var xs9_9 = Seq.Repeat(10, 9);
            var res9 = Seq.WithIndex(Seq.Zip(xs9_1, xs9_2, xs9_3, xs9_4, xs9_5, xs9_6, xs9_7, xs9_8, xs9_9));
            Assert.That(res9, Is.EqualTo(Seq.Zip(xs9_1, xs9_2, xs9_3, xs9_4, xs9_5, xs9_6, xs9_7, xs9_8, xs9_9, Seq.InitInfinite(i => i))));

            var xs10_1 = Seq.Repeat(10, 1);
            var xs10_2 = Seq.Repeat(10, 2);
            var xs10_3 = Seq.Repeat(10, 3);
            var xs10_4 = Seq.Repeat(10, 4);
            var xs10_5 = Seq.Repeat(10, 5);
            var xs10_6 = Seq.Repeat(10, 6);
            var xs10_7 = Seq.Repeat(10, 7);
            var xs10_8 = Seq.Repeat(10, 8);
            var xs10_9 = Seq.Repeat(10, 9);
            var xs10_10 = Seq.Repeat(10, 10);
            var res10 = Seq.WithIndex(Seq.Zip(xs10_1, xs10_2, xs10_3, xs10_4, xs10_5, xs10_6, xs10_7, xs10_8, xs10_9, xs10_10));
            Assert.That(res10, Is.EqualTo(Seq.Zip(xs10_1, xs10_2, xs10_3, xs10_4, xs10_5, xs10_6, xs10_7, xs10_8, xs10_9, xs10_10, Seq.InitInfinite(i => i))));

            var xs11_1 = Seq.Repeat(10, 1);
            var xs11_2 = Seq.Repeat(10, 2);
            var xs11_3 = Seq.Repeat(10, 3);
            var xs11_4 = Seq.Repeat(10, 4);
            var xs11_5 = Seq.Repeat(10, 5);
            var xs11_6 = Seq.Repeat(10, 6);
            var xs11_7 = Seq.Repeat(10, 7);
            var xs11_8 = Seq.Repeat(10, 8);
            var xs11_9 = Seq.Repeat(10, 9);
            var xs11_10 = Seq.Repeat(10, 10);
            var xs11_11 = Seq.Repeat(10, 11);
            var res11 = Seq.WithIndex(Seq.Zip(xs11_1, xs11_2, xs11_3, xs11_4, xs11_5, xs11_6, xs11_7, xs11_8, xs11_9, xs11_10, xs11_11));
            Assert.That(res11, Is.EqualTo(Seq.Zip(xs11_1, xs11_2, xs11_3, xs11_4, xs11_5, xs11_6, xs11_7, xs11_8, xs11_9, xs11_10, xs11_11, Seq.InitInfinite(i => i))));

            var xs12_1 = Seq.Repeat(10, 1);
            var xs12_2 = Seq.Repeat(10, 2);
            var xs12_3 = Seq.Repeat(10, 3);
            var xs12_4 = Seq.Repeat(10, 4);
            var xs12_5 = Seq.Repeat(10, 5);
            var xs12_6 = Seq.Repeat(10, 6);
            var xs12_7 = Seq.Repeat(10, 7);
            var xs12_8 = Seq.Repeat(10, 8);
            var xs12_9 = Seq.Repeat(10, 9);
            var xs12_10 = Seq.Repeat(10, 10);
            var xs12_11 = Seq.Repeat(10, 11);
            var xs12_12 = Seq.Repeat(10, 12);
            var res12 = Seq.WithIndex(Seq.Zip(xs12_1, xs12_2, xs12_3, xs12_4, xs12_5, xs12_6, xs12_7, xs12_8, xs12_9, xs12_10, xs12_11, xs12_12));
            Assert.That(res12, Is.EqualTo(Seq.Zip(xs12_1, xs12_2, xs12_3, xs12_4, xs12_5, xs12_6, xs12_7, xs12_8, xs12_9, xs12_10, xs12_11, xs12_12, Seq.InitInfinite(i => i))));

            var xs13_1 = Seq.Repeat(10, 1);
            var xs13_2 = Seq.Repeat(10, 2);
            var xs13_3 = Seq.Repeat(10, 3);
            var xs13_4 = Seq.Repeat(10, 4);
            var xs13_5 = Seq.Repeat(10, 5);
            var xs13_6 = Seq.Repeat(10, 6);
            var xs13_7 = Seq.Repeat(10, 7);
            var xs13_8 = Seq.Repeat(10, 8);
            var xs13_9 = Seq.Repeat(10, 9);
            var xs13_10 = Seq.Repeat(10, 10);
            var xs13_11 = Seq.Repeat(10, 11);
            var xs13_12 = Seq.Repeat(10, 12);
            var xs13_13 = Seq.Repeat(10, 13);
            var res13 = Seq.WithIndex(Seq.Zip(xs13_1, xs13_2, xs13_3, xs13_4, xs13_5, xs13_6, xs13_7, xs13_8, xs13_9, xs13_10, xs13_11, xs13_12, xs13_13));
            Assert.That(res13, Is.EqualTo(Seq.Zip(xs13_1, xs13_2, xs13_3, xs13_4, xs13_5, xs13_6, xs13_7, xs13_8, xs13_9, xs13_10, xs13_11, xs13_12, xs13_13, Seq.InitInfinite(i => i))));

            var xs14_1 = Seq.Repeat(10, 1);
            var xs14_2 = Seq.Repeat(10, 2);
            var xs14_3 = Seq.Repeat(10, 3);
            var xs14_4 = Seq.Repeat(10, 4);
            var xs14_5 = Seq.Repeat(10, 5);
            var xs14_6 = Seq.Repeat(10, 6);
            var xs14_7 = Seq.Repeat(10, 7);
            var xs14_8 = Seq.Repeat(10, 8);
            var xs14_9 = Seq.Repeat(10, 9);
            var xs14_10 = Seq.Repeat(10, 10);
            var xs14_11 = Seq.Repeat(10, 11);
            var xs14_12 = Seq.Repeat(10, 12);
            var xs14_13 = Seq.Repeat(10, 13);
            var xs14_14 = Seq.Repeat(10, 14);
            var res14 = Seq.WithIndex(Seq.Zip(xs14_1, xs14_2, xs14_3, xs14_4, xs14_5, xs14_6, xs14_7, xs14_8, xs14_9, xs14_10, xs14_11, xs14_12, xs14_13, xs14_14));
            Assert.That(res14, Is.EqualTo(Seq.Zip(xs14_1, xs14_2, xs14_3, xs14_4, xs14_5, xs14_6, xs14_7, xs14_8, xs14_9, xs14_10, xs14_11, xs14_12, xs14_13, xs14_14, Seq.InitInfinite(i => i))));

            var xs15_1 = Seq.Repeat(10, 1);
            var xs15_2 = Seq.Repeat(10, 2);
            var xs15_3 = Seq.Repeat(10, 3);
            var xs15_4 = Seq.Repeat(10, 4);
            var xs15_5 = Seq.Repeat(10, 5);
            var xs15_6 = Seq.Repeat(10, 6);
            var xs15_7 = Seq.Repeat(10, 7);
            var xs15_8 = Seq.Repeat(10, 8);
            var xs15_9 = Seq.Repeat(10, 9);
            var xs15_10 = Seq.Repeat(10, 10);
            var xs15_11 = Seq.Repeat(10, 11);
            var xs15_12 = Seq.Repeat(10, 12);
            var xs15_13 = Seq.Repeat(10, 13);
            var xs15_14 = Seq.Repeat(10, 14);
            var xs15_15 = Seq.Repeat(10, 15);
            var res15 = Seq.WithIndex(Seq.Zip(xs15_1, xs15_2, xs15_3, xs15_4, xs15_5, xs15_6, xs15_7, xs15_8, xs15_9, xs15_10, xs15_11, xs15_12, xs15_13, xs15_14, xs15_15));
            Assert.That(res15, Is.EqualTo(Seq.Zip(xs15_1, xs15_2, xs15_3, xs15_4, xs15_5, xs15_6, xs15_7, xs15_8, xs15_9, xs15_10, xs15_11, xs15_12, xs15_13, xs15_14, xs15_15, Seq.InitInfinite(i => i))));
        }
    }
}