
using System;

namespace LangExt.Playground.PatternMatching
{
    partial class Pattern
    {
        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1つ目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2つ目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2> And<T, U1, U2>(this IPattern<ISeq<T>, U1> self, IPattern<ISeq<T>, U2> nextPat)
        {
            return new SeqPattern<T, U1, U2>(self, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1つ目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2つ目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2> And<T, U1, U2>(this SeqPattern<T, U1> self, IPattern<ISeq<T>, U2> nextPat)
        {
            return new SeqPattern<T, U1, U2>(self.Pat1, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3> And<T, U1, U2, U3>(this SeqPattern<T, U1, U2> self, IPattern<ISeq<T>, U3> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3>(self.Pat1, self.Pat2, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4> And<T, U1, U2, U3, U4>(this SeqPattern<T, U1, U2, U3> self, IPattern<ISeq<T>, U4> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4>(self.Pat1, self.Pat2, self.Pat3, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <typeparam name="U5">5個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4, U5> And<T, U1, U2, U3, U4, U5>(this SeqPattern<T, U1, U2, U3, U4> self, IPattern<ISeq<T>, U5> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4, U5>(self.Pat1, self.Pat2, self.Pat3, self.Pat4, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <typeparam name="U5">5個目のパターンの結果の型</typeparam>
        /// <typeparam name="U6">6個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4, U5, U6> And<T, U1, U2, U3, U4, U5, U6>(this SeqPattern<T, U1, U2, U3, U4, U5> self, IPattern<ISeq<T>, U6> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4, U5, U6>(self.Pat1, self.Pat2, self.Pat3, self.Pat4, self.Pat5, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <typeparam name="U5">5個目のパターンの結果の型</typeparam>
        /// <typeparam name="U6">6個目のパターンの結果の型</typeparam>
        /// <typeparam name="U7">7個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4, U5, U6, U7> And<T, U1, U2, U3, U4, U5, U6, U7>(this SeqPattern<T, U1, U2, U3, U4, U5, U6> self, IPattern<ISeq<T>, U7> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4, U5, U6, U7>(self.Pat1, self.Pat2, self.Pat3, self.Pat4, self.Pat5, self.Pat6, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <typeparam name="U5">5個目のパターンの結果の型</typeparam>
        /// <typeparam name="U6">6個目のパターンの結果の型</typeparam>
        /// <typeparam name="U7">7個目のパターンの結果の型</typeparam>
        /// <typeparam name="U8">8個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8> And<T, U1, U2, U3, U4, U5, U6, U7, U8>(this SeqPattern<T, U1, U2, U3, U4, U5, U6, U7> self, IPattern<ISeq<T>, U8> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8>(self.Pat1, self.Pat2, self.Pat3, self.Pat4, self.Pat5, self.Pat6, self.Pat7, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <typeparam name="U5">5個目のパターンの結果の型</typeparam>
        /// <typeparam name="U6">6個目のパターンの結果の型</typeparam>
        /// <typeparam name="U7">7個目のパターンの結果の型</typeparam>
        /// <typeparam name="U8">8個目のパターンの結果の型</typeparam>
        /// <typeparam name="U9">9個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9> And<T, U1, U2, U3, U4, U5, U6, U7, U8, U9>(this SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8> self, IPattern<ISeq<T>, U9> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9>(self.Pat1, self.Pat2, self.Pat3, self.Pat4, self.Pat5, self.Pat6, self.Pat7, self.Pat8, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <typeparam name="U5">5個目のパターンの結果の型</typeparam>
        /// <typeparam name="U6">6個目のパターンの結果の型</typeparam>
        /// <typeparam name="U7">7個目のパターンの結果の型</typeparam>
        /// <typeparam name="U8">8個目のパターンの結果の型</typeparam>
        /// <typeparam name="U9">9個目のパターンの結果の型</typeparam>
        /// <typeparam name="U10">10個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10> And<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10>(this SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9> self, IPattern<ISeq<T>, U10> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10>(self.Pat1, self.Pat2, self.Pat3, self.Pat4, self.Pat5, self.Pat6, self.Pat7, self.Pat8, self.Pat9, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <typeparam name="U5">5個目のパターンの結果の型</typeparam>
        /// <typeparam name="U6">6個目のパターンの結果の型</typeparam>
        /// <typeparam name="U7">7個目のパターンの結果の型</typeparam>
        /// <typeparam name="U8">8個目のパターンの結果の型</typeparam>
        /// <typeparam name="U9">9個目のパターンの結果の型</typeparam>
        /// <typeparam name="U10">10個目のパターンの結果の型</typeparam>
        /// <typeparam name="U11">11個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11> And<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11>(this SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10> self, IPattern<ISeq<T>, U11> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11>(self.Pat1, self.Pat2, self.Pat3, self.Pat4, self.Pat5, self.Pat6, self.Pat7, self.Pat8, self.Pat9, self.Pat10, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <typeparam name="U5">5個目のパターンの結果の型</typeparam>
        /// <typeparam name="U6">6個目のパターンの結果の型</typeparam>
        /// <typeparam name="U7">7個目のパターンの結果の型</typeparam>
        /// <typeparam name="U8">8個目のパターンの結果の型</typeparam>
        /// <typeparam name="U9">9個目のパターンの結果の型</typeparam>
        /// <typeparam name="U10">10個目のパターンの結果の型</typeparam>
        /// <typeparam name="U11">11個目のパターンの結果の型</typeparam>
        /// <typeparam name="U12">12個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12> And<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12>(this SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11> self, IPattern<ISeq<T>, U12> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12>(self.Pat1, self.Pat2, self.Pat3, self.Pat4, self.Pat5, self.Pat6, self.Pat7, self.Pat8, self.Pat9, self.Pat10, self.Pat11, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <typeparam name="U5">5個目のパターンの結果の型</typeparam>
        /// <typeparam name="U6">6個目のパターンの結果の型</typeparam>
        /// <typeparam name="U7">7個目のパターンの結果の型</typeparam>
        /// <typeparam name="U8">8個目のパターンの結果の型</typeparam>
        /// <typeparam name="U9">9個目のパターンの結果の型</typeparam>
        /// <typeparam name="U10">10個目のパターンの結果の型</typeparam>
        /// <typeparam name="U11">11個目のパターンの結果の型</typeparam>
        /// <typeparam name="U12">12個目のパターンの結果の型</typeparam>
        /// <typeparam name="U13">13個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13> And<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13>(this SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12> self, IPattern<ISeq<T>, U13> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13>(self.Pat1, self.Pat2, self.Pat3, self.Pat4, self.Pat5, self.Pat6, self.Pat7, self.Pat8, self.Pat9, self.Pat10, self.Pat11, self.Pat12, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <typeparam name="U5">5個目のパターンの結果の型</typeparam>
        /// <typeparam name="U6">6個目のパターンの結果の型</typeparam>
        /// <typeparam name="U7">7個目のパターンの結果の型</typeparam>
        /// <typeparam name="U8">8個目のパターンの結果の型</typeparam>
        /// <typeparam name="U9">9個目のパターンの結果の型</typeparam>
        /// <typeparam name="U10">10個目のパターンの結果の型</typeparam>
        /// <typeparam name="U11">11個目のパターンの結果の型</typeparam>
        /// <typeparam name="U12">12個目のパターンの結果の型</typeparam>
        /// <typeparam name="U13">13個目のパターンの結果の型</typeparam>
        /// <typeparam name="U14">14個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13, U14> And<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13, U14>(this SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13> self, IPattern<ISeq<T>, U14> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13, U14>(self.Pat1, self.Pat2, self.Pat3, self.Pat4, self.Pat5, self.Pat6, self.Pat7, self.Pat8, self.Pat9, self.Pat10, self.Pat11, self.Pat12, self.Pat13, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <typeparam name="U5">5個目のパターンの結果の型</typeparam>
        /// <typeparam name="U6">6個目のパターンの結果の型</typeparam>
        /// <typeparam name="U7">7個目のパターンの結果の型</typeparam>
        /// <typeparam name="U8">8個目のパターンの結果の型</typeparam>
        /// <typeparam name="U9">9個目のパターンの結果の型</typeparam>
        /// <typeparam name="U10">10個目のパターンの結果の型</typeparam>
        /// <typeparam name="U11">11個目のパターンの結果の型</typeparam>
        /// <typeparam name="U12">12個目のパターンの結果の型</typeparam>
        /// <typeparam name="U13">13個目のパターンの結果の型</typeparam>
        /// <typeparam name="U14">14個目のパターンの結果の型</typeparam>
        /// <typeparam name="U15">15個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13, U14, U15> And<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13, U14, U15>(this SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13, U14> self, IPattern<ISeq<T>, U15> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13, U14, U15>(self.Pat1, self.Pat2, self.Pat3, self.Pat4, self.Pat5, self.Pat6, self.Pat7, self.Pat8, self.Pat9, self.Pat10, self.Pat11, self.Pat12, self.Pat13, self.Pat14, nextPat);
        }

        /// <summary>
        /// パターンを連結します。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U1">1個目のパターンの結果の型</typeparam>
        /// <typeparam name="U2">2個目のパターンの結果の型</typeparam>
        /// <typeparam name="U3">3個目のパターンの結果の型</typeparam>
        /// <typeparam name="U4">4個目のパターンの結果の型</typeparam>
        /// <typeparam name="U5">5個目のパターンの結果の型</typeparam>
        /// <typeparam name="U6">6個目のパターンの結果の型</typeparam>
        /// <typeparam name="U7">7個目のパターンの結果の型</typeparam>
        /// <typeparam name="U8">8個目のパターンの結果の型</typeparam>
        /// <typeparam name="U9">9個目のパターンの結果の型</typeparam>
        /// <typeparam name="U10">10個目のパターンの結果の型</typeparam>
        /// <typeparam name="U11">11個目のパターンの結果の型</typeparam>
        /// <typeparam name="U12">12個目のパターンの結果の型</typeparam>
        /// <typeparam name="U13">13個目のパターンの結果の型</typeparam>
        /// <typeparam name="U14">14個目のパターンの結果の型</typeparam>
        /// <typeparam name="U15">15個目のパターンの結果の型</typeparam>
        /// <typeparam name="U16">16個目のパターンの結果の型</typeparam>
        /// <param name="self">元となるパターン</param>
        /// <param name="nextPat">連結するパターン</param>
        /// <returns>連結されたパターン</returns>
        public static SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13, U14, U15, U16> And<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13, U14, U15, U16>(this SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13, U14, U15> self, IPattern<ISeq<T>, U16> nextPat)
        {
            return new SeqPattern<T, U1, U2, U3, U4, U5, U6, U7, U8, U9, U10, U11, U12, U13, U14, U15, U16>(self.Pat1, self.Pat2, self.Pat3, self.Pat4, self.Pat5, self.Pat6, self.Pat7, self.Pat8, self.Pat9, self.Pat10, self.Pat11, self.Pat12, self.Pat13, self.Pat14, self.Pat15, nextPat);
        }
    }
}