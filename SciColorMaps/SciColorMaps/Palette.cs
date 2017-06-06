﻿using System;
using System.Collections.Generic;

namespace SciColorMaps
{
#if !RECTANGULAR

    /// <summary>
    /// Class containing colormaps (palettes) imported from matplotlib
    /// 
    /// =========================== IMPORTANT NOTES! ==========================
    /// 
    /// 1)
    /// Accessing elements in jagged arrays is significantly faster(up to 40%)
    /// compared to rectangular arrays, so the following code is compiled by default.
    /// If an efficient memory management is of more importance then compile
    /// with the 'RECTANGULAR' conditional symbol.
    /// 
    /// 2)
    /// Palette arrays are instantiated LAZILY in the calling code, e.g.:
    ///      var palette = Palette.Afmhot.Value;
    /// 
    /// 3)
    /// All palettes are READONLY arrays. That means they are NOT consts
    /// and can be modified by calling code. It is AGAINST the contract,
    /// however for the sake of performance there are currently no 
    /// additional checks or converting to ReadOnlyCollection in the code.
    /// 
    /// </summary>
    public static class Palette
    {
        /// <summary>
        /// Number of base colors in palette
        /// </summary>
        public const int Resolution = 256;

    #region palettes

        /// <summary>
        /// Colormap "afmhot" taken from matplotlib
        /// </summary>
        public static readonly Lazy<byte[][]> Afmhot = new Lazy<byte[][]>(() => new byte[][]
        {
            new byte[] {  0,   0,   0}, new byte[] {  2,   0,   0}, new byte[] {  4,   0,   0}, new byte[] {  6,   0,   0},
            new byte[] {  8,   0,   0}, new byte[] { 10,   0,   0}, new byte[] { 12,   0,   0}, new byte[] { 14,   0,   0},
            new byte[] { 16,   0,   0}, new byte[] { 18,   0,   0}, new byte[] { 20,   0,   0}, new byte[] { 22,   0,   0},
            new byte[] { 24,   0,   0}, new byte[] { 26,   0,   0}, new byte[] { 28,   0,   0}, new byte[] { 30,   0,   0},
            new byte[] { 32,   0,   0}, new byte[] { 34,   0,   0}, new byte[] { 36,   0,   0}, new byte[] { 38,   0,   0},
            new byte[] { 40,   0,   0}, new byte[] { 42,   0,   0}, new byte[] { 44,   0,   0}, new byte[] { 46,   0,   0},
            new byte[] { 48,   0,   0}, new byte[] { 50,   0,   0}, new byte[] { 52,   0,   0}, new byte[] { 54,   0,   0},
            new byte[] { 56,   0,   0}, new byte[] { 58,   0,   0}, new byte[] { 60,   0,   0}, new byte[] { 62,   0,   0},
            new byte[] { 64,   0,   0}, new byte[] { 65,   0,   0}, new byte[] { 68,   0,   0}, new byte[] { 70,   0,   0},
            new byte[] { 72,   0,   0}, new byte[] { 73,   0,   0}, new byte[] { 76,   0,   0}, new byte[] { 78,   0,   0},
            new byte[] { 80,   0,   0}, new byte[] { 81,   0,   0}, new byte[] { 84,   0,   0}, new byte[] { 86,   0,   0},
            new byte[] { 88,   0,   0}, new byte[] { 89,   0,   0}, new byte[] { 92,   0,   0}, new byte[] { 94,   0,   0},
            new byte[] { 96,   0,   0}, new byte[] { 97,   0,   0}, new byte[] {100,   0,   0}, new byte[] {102,   0,   0},
            new byte[] {104,   0,   0}, new byte[] {105,   0,   0}, new byte[] {108,   0,   0}, new byte[] {110,   0,   0},
            new byte[] {112,   0,   0}, new byte[] {113,   0,   0}, new byte[] {116,   0,   0}, new byte[] {118,   0,   0},
            new byte[] {120,   0,   0}, new byte[] {121,   0,   0}, new byte[] {124,   0,   0}, new byte[] {126,   0,   0},
            new byte[] {128,   0,   0}, new byte[] {130,   2,   0}, new byte[] {131,   4,   0}, new byte[] {134,   6,   0},
            new byte[] {136,   8,   0}, new byte[] {138,  10,   0}, new byte[] {140,  12,   0}, new byte[] {142,  14,   0},
            new byte[] {144,  16,   0}, new byte[] {146,  18,   0}, new byte[] {147,  20,   0}, new byte[] {150,  22,   0},
            new byte[] {152,  24,   0}, new byte[] {154,  26,   0}, new byte[] {156,  28,   0}, new byte[] {158,  30,   0},
            new byte[] {160,  32,   0}, new byte[] {162,  34,   0}, new byte[] {163,  36,   0}, new byte[] {166,  38,   0},
            new byte[] {168,  40,   0}, new byte[] {170,  42,   0}, new byte[] {172,  44,   0}, new byte[] {174,  46,   0},
            new byte[] {176,  48,   0}, new byte[] {178,  50,   0}, new byte[] {179,  52,   0}, new byte[] {182,  54,   0},
            new byte[] {184,  56,   0}, new byte[] {186,  58,   0}, new byte[] {188,  60,   0}, new byte[] {190,  62,   0},
            new byte[] {192,  64,   0}, new byte[] {194,  66,   0}, new byte[] {195,  68,   0}, new byte[] {198,  70,   0},
            new byte[] {200,  72,   0}, new byte[] {202,  74,   0}, new byte[] {204,  76,   0}, new byte[] {206,  78,   0},
            new byte[] {208,  80,   0}, new byte[] {210,  82,   0}, new byte[] {211,  84,   0}, new byte[] {214,  86,   0},
            new byte[] {216,  88,   0}, new byte[] {218,  90,   0}, new byte[] {220,  92,   0}, new byte[] {222,  94,   0},
            new byte[] {224,  96,   0}, new byte[] {226,  98,   0}, new byte[] {227, 100,   0}, new byte[] {230, 102,   0},
            new byte[] {232, 104,   0}, new byte[] {234, 106,   0}, new byte[] {236, 108,   0}, new byte[] {238, 110,   0},
            new byte[] {240, 112,   0}, new byte[] {242, 114,   0}, new byte[] {243, 116,   0}, new byte[] {246, 118,   0},
            new byte[] {248, 120,   0}, new byte[] {250, 122,   0}, new byte[] {252, 124,   0}, new byte[] {254, 126,   0},
            new byte[] {255, 128,   0}, new byte[] {255, 130,   2}, new byte[] {255, 132,   4}, new byte[] {255, 134,   6},
            new byte[] {255, 136,   8}, new byte[] {255, 138,  11}, new byte[] {255, 140,  13}, new byte[] {255, 142,  15},
            new byte[] {255, 144,  16}, new byte[] {255, 146,  18}, new byte[] {255, 148,  20}, new byte[] {255, 150,  22},
            new byte[] {255, 152,  25}, new byte[] {255, 154,  27}, new byte[] {255, 156,  29}, new byte[] {255, 158,  31},
            new byte[] {255, 160,  32}, new byte[] {255, 162,  34}, new byte[] {255, 164,  36}, new byte[] {255, 166,  38},
            new byte[] {255, 168,  40}, new byte[] {255, 170,  43}, new byte[] {255, 172,  45}, new byte[] {255, 174,  47},
            new byte[] {255, 176,  48}, new byte[] {255, 178,  50}, new byte[] {255, 180,  52}, new byte[] {255, 182,  54},
            new byte[] {255, 184,  57}, new byte[] {255, 186,  59}, new byte[] {255, 188,  61}, new byte[] {255, 190,  63},
            new byte[] {255, 192,  65}, new byte[] {255, 194,  66}, new byte[] {255, 196,  68}, new byte[] {255, 198,  70},
            new byte[] {255, 200,  72}, new byte[] {255, 202,  75}, new byte[] {255, 204,  77}, new byte[] {255, 206,  79},
            new byte[] {255, 208,  81}, new byte[] {255, 210,  82}, new byte[] {255, 212,  84}, new byte[] {255, 214,  86},
            new byte[] {255, 216,  89}, new byte[] {255, 218,  91}, new byte[] {255, 220,  93}, new byte[] {255, 222,  95},
            new byte[] {255, 224,  97}, new byte[] {255, 226,  98}, new byte[] {255, 228, 100}, new byte[] {255, 230, 102},
            new byte[] {255, 232, 104}, new byte[] {255, 234, 107}, new byte[] {255, 236, 109}, new byte[] {255, 238, 111},
            new byte[] {255, 240, 113}, new byte[] {255, 242, 114}, new byte[] {255, 244, 116}, new byte[] {255, 246, 118},
            new byte[] {255, 248, 121}, new byte[] {255, 250, 123}, new byte[] {255, 252, 125}, new byte[] {255, 254, 127},
            new byte[] {255, 255, 129}, new byte[] {255, 255, 131}, new byte[] {255, 255, 132}, new byte[] {255, 255, 134},
            new byte[] {255, 255, 136}, new byte[] {255, 255, 139}, new byte[] {255, 255, 141}, new byte[] {255, 255, 143},
            new byte[] {255, 255, 145}, new byte[] {255, 255, 147}, new byte[] {255, 255, 148}, new byte[] {255, 255, 150},
            new byte[] {255, 255, 153}, new byte[] {255, 255, 155}, new byte[] {255, 255, 157}, new byte[] {255, 255, 159},
            new byte[] {255, 255, 161}, new byte[] {255, 255, 163}, new byte[] {255, 255, 164}, new byte[] {255, 255, 166},
            new byte[] {255, 255, 168}, new byte[] {255, 255, 171}, new byte[] {255, 255, 173}, new byte[] {255, 255, 175},
            new byte[] {255, 255, 177}, new byte[] {255, 255, 179}, new byte[] {255, 255, 180}, new byte[] {255, 255, 182},
            new byte[] {255, 255, 185}, new byte[] {255, 255, 187}, new byte[] {255, 255, 189}, new byte[] {255, 255, 191},
            new byte[] {255, 255, 193}, new byte[] {255, 255, 195}, new byte[] {255, 255, 196}, new byte[] {255, 255, 198},
            new byte[] {255, 255, 200}, new byte[] {255, 255, 203}, new byte[] {255, 255, 205}, new byte[] {255, 255, 207},
            new byte[] {255, 255, 209}, new byte[] {255, 255, 211}, new byte[] {255, 255, 212}, new byte[] {255, 255, 214},
            new byte[] {255, 255, 217}, new byte[] {255, 255, 219}, new byte[] {255, 255, 221}, new byte[] {255, 255, 223},
            new byte[] {255, 255, 225}, new byte[] {255, 255, 227}, new byte[] {255, 255, 228}, new byte[] {255, 255, 230},
            new byte[] {255, 255, 232}, new byte[] {255, 255, 235}, new byte[] {255, 255, 237}, new byte[] {255, 255, 239},
            new byte[] {255, 255, 241}, new byte[] {255, 255, 243}, new byte[] {255, 255, 244}, new byte[] {255, 255, 246},
            new byte[] {255, 255, 249}, new byte[] {255, 255, 251}, new byte[] {255, 255, 253}, new byte[] {255, 255, 255}
        });

        /// <summary>
        /// Colormap "gist_earth" taken from matplotlib
        /// </summary>
        public static readonly Lazy<byte[][]> GistEarth = new Lazy<byte[][]>(() => new byte[][]
        {
            new byte[] {  0,   0,   0}, new byte[] {  0,   0,  43}, new byte[] {  1,   0,  56}, new byte[] {  1,   0,  67},
            new byte[] {  2,   0,  78}, new byte[] {  3,   0,  88}, new byte[] {  3,   0,  99}, new byte[] {  4,   0, 110},
            new byte[] {  5,   2, 115}, new byte[] {  5,   4, 116}, new byte[] {  6,   6, 116}, new byte[] {  7,   9, 116},
            new byte[] {  7,  11, 116}, new byte[] {  8,  13, 116}, new byte[] {  9,  16, 117}, new byte[] {  9,  18, 117},
            new byte[] { 10,  20, 117}, new byte[] { 11,  22, 117}, new byte[] { 11,  25, 117}, new byte[] { 12,  27, 117},
            new byte[] { 13,  29, 118}, new byte[] { 13,  32, 118}, new byte[] { 14,  34, 118}, new byte[] { 15,  36, 118},
            new byte[] { 15,  39, 118}, new byte[] { 16,  41, 119}, new byte[] { 17,  43, 119}, new byte[] { 17,  45, 119},
            new byte[] { 18,  48, 119}, new byte[] { 19,  50, 119}, new byte[] { 19,  52, 119}, new byte[] { 20,  54, 120},
            new byte[] { 21,  56, 120}, new byte[] { 21,  58, 120}, new byte[] { 22,  60, 120}, new byte[] { 23,  62, 120},
            new byte[] { 23,  64, 121}, new byte[] { 24,  66, 121}, new byte[] { 25,  69, 121}, new byte[] { 25,  71, 121},
            new byte[] { 26,  73, 121}, new byte[] { 27,  75, 121}, new byte[] { 27,  77, 122}, new byte[] { 28,  79, 122},
            new byte[] { 29,  81, 122}, new byte[] { 29,  83, 122}, new byte[] { 30,  84, 122}, new byte[] { 31,  86, 123},
            new byte[] { 31,  88, 123}, new byte[] { 32,  90, 123}, new byte[] { 33,  92, 123}, new byte[] { 33,  94, 123},
            new byte[] { 34,  96, 123}, new byte[] { 35,  97, 124}, new byte[] { 35,  99, 124}, new byte[] { 36, 101, 124},
            new byte[] { 37, 102, 124}, new byte[] { 37, 104, 124}, new byte[] { 38, 105, 125}, new byte[] { 39, 107, 125},
            new byte[] { 39, 109, 125}, new byte[] { 40, 110, 125}, new byte[] { 41, 112, 125}, new byte[] { 41, 113, 125},
            new byte[] { 42, 115, 126}, new byte[] { 43, 116, 126}, new byte[] { 43, 118, 126}, new byte[] { 44, 120, 126},
            new byte[] { 45, 121, 126}, new byte[] { 45, 123, 127}, new byte[] { 46, 124, 127}, new byte[] { 47, 126, 127},
            new byte[] { 47, 127, 127}, new byte[] { 48, 128, 126}, new byte[] { 48, 129, 125}, new byte[] { 49, 129, 123},
            new byte[] { 49, 130, 122}, new byte[] { 50, 130, 121}, new byte[] { 50, 131, 120}, new byte[] { 51, 132, 119},
            new byte[] { 51, 132, 117}, new byte[] { 52, 133, 116}, new byte[] { 52, 133, 115}, new byte[] { 53, 134, 114},
            new byte[] { 53, 134, 112}, new byte[] { 54, 135, 111}, new byte[] { 54, 136, 110}, new byte[] { 55, 136, 109},
            new byte[] { 55, 137, 108}, new byte[] { 56, 137, 106}, new byte[] { 56, 138, 105}, new byte[] { 56, 138, 104},
            new byte[] { 57, 139, 103}, new byte[] { 57, 140, 101}, new byte[] { 58, 140, 100}, new byte[] { 58, 141,  99},
            new byte[] { 59, 141,  98}, new byte[] { 59, 142,  97}, new byte[] { 60, 142,  95}, new byte[] { 60, 143,  94},
            new byte[] { 61, 144,  93}, new byte[] { 61, 144,  92}, new byte[] { 62, 145,  90}, new byte[] { 62, 145,  89},
            new byte[] { 63, 146,  88}, new byte[] { 63, 147,  87}, new byte[] { 64, 147,  85}, new byte[] { 64, 148,  84},
            new byte[] { 64, 148,  83}, new byte[] { 65, 149,  82}, new byte[] { 65, 149,  81}, new byte[] { 66, 150,  79},
            new byte[] { 66, 151,  78}, new byte[] { 67, 151,  77}, new byte[] { 67, 152,  76}, new byte[] { 68, 152,  74},
            new byte[] { 68, 153,  73}, new byte[] { 69, 153,  72}, new byte[] { 71, 154,  71}, new byte[] { 73, 155,  70},
            new byte[] { 75, 155,  70}, new byte[] { 78, 156,  71}, new byte[] { 80, 156,  71}, new byte[] { 82, 157,  72},
            new byte[] { 84, 157,  72}, new byte[] { 87, 158,  73}, new byte[] { 89, 159,  74}, new byte[] { 91, 159,  74},
            new byte[] { 93, 160,  75}, new byte[] { 95, 160,  75}, new byte[] { 98, 161,  76}, new byte[] {100, 161,  77},
            new byte[] {102, 162,  77}, new byte[] {104, 163,  78}, new byte[] {107, 163,  78}, new byte[] {109, 163,  79},
            new byte[] {111, 164,  79}, new byte[] {113, 164,  80}, new byte[] {115, 165,  81}, new byte[] {118, 165,  81},
            new byte[] {120, 166,  82}, new byte[] {121, 166,  82}, new byte[] {123, 167,  82}, new byte[] {125, 167,  82},
            new byte[] {126, 167,  83}, new byte[] {128, 168,  83}, new byte[] {130, 168,  83}, new byte[] {131, 169,  84},
            new byte[] {133, 169,  84}, new byte[] {135, 170,  84}, new byte[] {136, 170,  85}, new byte[] {138, 171,  85},
            new byte[] {140, 171,  85}, new byte[] {141, 171,  86}, new byte[] {143, 172,  86}, new byte[] {145, 172,  86},
            new byte[] {146, 173,  87}, new byte[] {148, 173,  87}, new byte[] {150, 174,  87}, new byte[] {151, 174,  88},
            new byte[] {153, 174,  88}, new byte[] {154, 175,  88}, new byte[] {156, 175,  88}, new byte[] {158, 176,  89},
            new byte[] {159, 176,  89}, new byte[] {161, 177,  89}, new byte[] {163, 177,  90}, new byte[] {164, 178,  90},
            new byte[] {166, 178,  90}, new byte[] {168, 178,  91}, new byte[] {169, 179,  91}, new byte[] {171, 179,  91},
            new byte[] {173, 180,  92}, new byte[] {174, 180,  92}, new byte[] {176, 181,  92}, new byte[] {178, 181,  93},
            new byte[] {179, 181,  93}, new byte[] {181, 182,  93}, new byte[] {182, 182,  94}, new byte[] {183, 181,  94},
            new byte[] {183, 181,  94}, new byte[] {184, 180,  95}, new byte[] {184, 179,  95}, new byte[] {185, 178,  95},
            new byte[] {185, 177,  95}, new byte[] {185, 176,  96}, new byte[] {186, 175,  96}, new byte[] {186, 175,  96},
            new byte[] {187, 174,  97}, new byte[] {187, 173,  97}, new byte[] {188, 172,  97}, new byte[] {188, 171,  98},
            new byte[] {188, 170,  98}, new byte[] {189, 169,  98}, new byte[] {189, 169,  99}, new byte[] {190, 168,  99},
            new byte[] {190, 167,  99}, new byte[] {190, 166, 100}, new byte[] {191, 165, 100}, new byte[] {191, 164, 100},
            new byte[] {192, 163, 101}, new byte[] {192, 163, 103}, new byte[] {193, 163, 105}, new byte[] {194, 163, 108},
            new byte[] {195, 164, 110}, new byte[] {197, 164, 113}, new byte[] {198, 165, 115}, new byte[] {199, 166, 118},
            new byte[] {200, 166, 120}, new byte[] {201, 167, 123}, new byte[] {202, 168, 125}, new byte[] {203, 169, 127},
            new byte[] {204, 170, 130}, new byte[] {206, 171, 132}, new byte[] {207, 172, 135}, new byte[] {208, 173, 137},
            new byte[] {209, 173, 140}, new byte[] {210, 174, 142}, new byte[] {211, 175, 145}, new byte[] {212, 176, 147},
            new byte[] {213, 177, 150}, new byte[] {214, 178, 152}, new byte[] {216, 179, 154}, new byte[] {217, 181, 157},
            new byte[] {218, 182, 159}, new byte[] {219, 183, 162}, new byte[] {220, 185, 164}, new byte[] {221, 186, 167},
            new byte[] {222, 188, 169}, new byte[] {223, 189, 172}, new byte[] {225, 191, 175}, new byte[] {226, 193, 178},
            new byte[] {227, 195, 181}, new byte[] {228, 197, 184}, new byte[] {229, 199, 187}, new byte[] {230, 201, 190},
            new byte[] {231, 203, 193}, new byte[] {232, 205, 196}, new byte[] {233, 207, 199}, new byte[] {235, 209, 202},
            new byte[] {236, 211, 205}, new byte[] {237, 213, 208}, new byte[] {238, 215, 211}, new byte[] {239, 217, 214},
            new byte[] {240, 220, 217}, new byte[] {241, 222, 220}, new byte[] {242, 224, 223}, new byte[] {244, 227, 226},
            new byte[] {245, 230, 229}, new byte[] {246, 233, 232}, new byte[] {247, 236, 235}, new byte[] {248, 239, 238},
            new byte[] {249, 242, 241}, new byte[] {250, 245, 244}, new byte[] {251, 248, 247}, new byte[] {253, 250, 250}
        });

        /// <summary>
        /// Colormap "inferno" taken from matplotlib
        /// </summary>
        public static readonly Lazy<byte[][]> Inferno = new Lazy<byte[][]>(() => new byte[][]
        {
            new byte[] {  0,   0,   3}, new byte[] {  0,   0,   4}, new byte[] {  0,   0,   6}, new byte[] {  1,   0,   7},
            new byte[] {  1,   1,   9}, new byte[] {  1,   1,  11}, new byte[] {  2,   1,  14}, new byte[] {  2,   2,  16},
            new byte[] {  3,   2,  18}, new byte[] {  4,   3,  20}, new byte[] {  4,   3,  22}, new byte[] {  5,   4,  24},
            new byte[] {  6,   4,  27}, new byte[] {  7,   5,  29}, new byte[] {  8,   6,  31}, new byte[] {  9,   6,  33},
            new byte[] { 10,   7,  35}, new byte[] { 11,   7,  38}, new byte[] { 13,   8,  40}, new byte[] { 14,   8,  42},
            new byte[] { 15,   9,  45}, new byte[] { 16,   9,  47}, new byte[] { 18,  10,  50}, new byte[] { 19,  10,  52},
            new byte[] { 20,  11,  54}, new byte[] { 22,  11,  57}, new byte[] { 23,  11,  59}, new byte[] { 25,  11,  62},
            new byte[] { 26,  11,  64}, new byte[] { 28,  12,  67}, new byte[] { 29,  12,  69}, new byte[] { 31,  12,  71},
            new byte[] { 32,  12,  74}, new byte[] { 34,  11,  76}, new byte[] { 36,  11,  78}, new byte[] { 38,  11,  80},
            new byte[] { 39,  11,  82}, new byte[] { 41,  11,  84}, new byte[] { 43,  10,  86}, new byte[] { 45,  10,  88},
            new byte[] { 46,  10,  90}, new byte[] { 48,  10,  92}, new byte[] { 50,   9,  93}, new byte[] { 52,   9,  95},
            new byte[] { 53,   9,  96}, new byte[] { 55,   9,  97}, new byte[] { 57,   9,  98}, new byte[] { 59,   9, 100},
            new byte[] { 60,   9, 101}, new byte[] { 62,   9, 102}, new byte[] { 64,   9, 102}, new byte[] { 65,   9, 103},
            new byte[] { 67,  10, 104}, new byte[] { 69,  10, 105}, new byte[] { 70,  10, 105}, new byte[] { 72,  11, 106},
            new byte[] { 74,  11, 106}, new byte[] { 75,  12, 107}, new byte[] { 77,  12, 107}, new byte[] { 79,  13, 108},
            new byte[] { 80,  13, 108}, new byte[] { 82,  14, 108}, new byte[] { 83,  14, 109}, new byte[] { 85,  15, 109},
            new byte[] { 87,  15, 109}, new byte[] { 88,  16, 109}, new byte[] { 90,  17, 109}, new byte[] { 91,  17, 110},
            new byte[] { 93,  18, 110}, new byte[] { 95,  18, 110}, new byte[] { 96,  19, 110}, new byte[] { 98,  20, 110},
            new byte[] { 99,  20, 110}, new byte[] {101,  21, 110}, new byte[] {102,  21, 110}, new byte[] {104,  22, 110},
            new byte[] {106,  23, 110}, new byte[] {107,  23, 110}, new byte[] {109,  24, 110}, new byte[] {110,  24, 110},
            new byte[] {112,  25, 110}, new byte[] {114,  25, 109}, new byte[] {115,  26, 109}, new byte[] {117,  27, 109},
            new byte[] {118,  27, 109}, new byte[] {120,  28, 109}, new byte[] {122,  28, 109}, new byte[] {123,  29, 108},
            new byte[] {125,  29, 108}, new byte[] {126,  30, 108}, new byte[] {128,  31, 107}, new byte[] {129,  31, 107},
            new byte[] {131,  32, 107}, new byte[] {133,  32, 106}, new byte[] {134,  33, 106}, new byte[] {136,  33, 106},
            new byte[] {137,  34, 105}, new byte[] {139,  34, 105}, new byte[] {141,  35, 105}, new byte[] {142,  36, 104},
            new byte[] {144,  36, 104}, new byte[] {145,  37, 103}, new byte[] {147,  37, 103}, new byte[] {149,  38, 102},
            new byte[] {150,  38, 102}, new byte[] {152,  39, 101}, new byte[] {153,  40, 100}, new byte[] {155,  40, 100},
            new byte[] {156,  41,  99}, new byte[] {158,  41,  99}, new byte[] {160,  42,  98}, new byte[] {161,  43,  97},
            new byte[] {163,  43,  97}, new byte[] {164,  44,  96}, new byte[] {166,  44,  95}, new byte[] {167,  45,  95},
            new byte[] {169,  46,  94}, new byte[] {171,  46,  93}, new byte[] {172,  47,  92}, new byte[] {174,  48,  91},
            new byte[] {175,  49,  91}, new byte[] {177,  49,  90}, new byte[] {178,  50,  89}, new byte[] {180,  51,  88},
            new byte[] {181,  51,  87}, new byte[] {183,  52,  86}, new byte[] {184,  53,  86}, new byte[] {186,  54,  85},
            new byte[] {187,  55,  84}, new byte[] {189,  55,  83}, new byte[] {190,  56,  82}, new byte[] {191,  57,  81},
            new byte[] {193,  58,  80}, new byte[] {194,  59,  79}, new byte[] {196,  60,  78}, new byte[] {197,  61,  77},
            new byte[] {199,  62,  76}, new byte[] {200,  62,  75}, new byte[] {201,  63,  74}, new byte[] {203,  64,  73},
            new byte[] {204,  65,  72}, new byte[] {205,  66,  71}, new byte[] {207,  68,  70}, new byte[] {208,  69,  68},
            new byte[] {209,  70,  67}, new byte[] {210,  71,  66}, new byte[] {212,  72,  65}, new byte[] {213,  73,  64},
            new byte[] {214,  74,  63}, new byte[] {215,  75,  62}, new byte[] {217,  77,  61}, new byte[] {218,  78,  59},
            new byte[] {219,  79,  58}, new byte[] {220,  80,  57}, new byte[] {221,  82,  56}, new byte[] {222,  83,  55},
            new byte[] {223,  84,  54}, new byte[] {224,  86,  52}, new byte[] {226,  87,  51}, new byte[] {227,  88,  50},
            new byte[] {228,  90,  49}, new byte[] {229,  91,  48}, new byte[] {230,  92,  46}, new byte[] {230,  94,  45},
            new byte[] {231,  95,  44}, new byte[] {232,  97,  43}, new byte[] {233,  98,  42}, new byte[] {234, 100,  40},
            new byte[] {235, 101,  39}, new byte[] {236, 103,  38}, new byte[] {237, 104,  37}, new byte[] {237, 106,  35},
            new byte[] {238, 108,  34}, new byte[] {239, 109,  33}, new byte[] {240, 111,  31}, new byte[] {240, 112,  30},
            new byte[] {241, 114,  29}, new byte[] {242, 116,  28}, new byte[] {242, 117,  26}, new byte[] {243, 119,  25},
            new byte[] {243, 121,  24}, new byte[] {244, 122,  22}, new byte[] {245, 124,  21}, new byte[] {245, 126,  20},
            new byte[] {246, 128,  18}, new byte[] {246, 129,  17}, new byte[] {247, 131,  16}, new byte[] {247, 133,  14},
            new byte[] {248, 135,  13}, new byte[] {248, 136,  12}, new byte[] {248, 138,  11}, new byte[] {249, 140,   9},
            new byte[] {249, 142,   8}, new byte[] {249, 144,   8}, new byte[] {250, 145,   7}, new byte[] {250, 147,   6},
            new byte[] {250, 149,   6}, new byte[] {250, 151,   6}, new byte[] {251, 153,   6}, new byte[] {251, 155,   6},
            new byte[] {251, 157,   6}, new byte[] {251, 158,   7}, new byte[] {251, 160,   7}, new byte[] {251, 162,   8},
            new byte[] {251, 164,  10}, new byte[] {251, 166,  11}, new byte[] {251, 168,  13}, new byte[] {251, 170,  14},
            new byte[] {251, 172,  16}, new byte[] {251, 174,  18}, new byte[] {251, 176,  20}, new byte[] {251, 177,  22},
            new byte[] {251, 179,  24}, new byte[] {251, 181,  26}, new byte[] {251, 183,  28}, new byte[] {251, 185,  30},
            new byte[] {250, 187,  33}, new byte[] {250, 189,  35}, new byte[] {250, 191,  37}, new byte[] {250, 193,  40},
            new byte[] {249, 195,  42}, new byte[] {249, 197,  44}, new byte[] {249, 199,  47}, new byte[] {248, 201,  49},
            new byte[] {248, 203,  52}, new byte[] {248, 205,  55}, new byte[] {247, 207,  58}, new byte[] {247, 209,  60},
            new byte[] {246, 211,  63}, new byte[] {246, 213,  66}, new byte[] {245, 215,  69}, new byte[] {245, 217,  72},
            new byte[] {244, 219,  75}, new byte[] {244, 220,  79}, new byte[] {243, 222,  82}, new byte[] {243, 224,  86},
            new byte[] {243, 226,  89}, new byte[] {242, 228,  93}, new byte[] {242, 230,  96}, new byte[] {241, 232, 100},
            new byte[] {241, 233, 104}, new byte[] {241, 235, 108}, new byte[] {241, 237, 112}, new byte[] {241, 238, 116},
            new byte[] {241, 240, 121}, new byte[] {241, 242, 125}, new byte[] {242, 243, 129}, new byte[] {242, 244, 133},
            new byte[] {243, 246, 137}, new byte[] {244, 247, 141}, new byte[] {245, 248, 145}, new byte[] {246, 250, 149},
            new byte[] {247, 251, 153}, new byte[] {249, 252, 157}, new byte[] {250, 253, 160}, new byte[] {252, 254, 164}
        });

        /// <summary>
        /// Colormap "terrain" taken from matplotlib
        /// </summary>
        public static readonly Lazy<byte[][]> Terrain = new Lazy<byte[][]>(() => new byte[][]
        {
            new byte[] { 51,  51, 153}, new byte[] { 49,  53, 155}, new byte[] { 48,  56, 158}, new byte[] { 47,  59, 161},
            new byte[] { 45,  61, 163}, new byte[] { 44,  64, 166}, new byte[] { 43,  67, 169}, new byte[] { 41,  69, 171},
            new byte[] { 40,  72, 174}, new byte[] { 39,  75, 177}, new byte[] { 37,  77, 179}, new byte[] { 36,  80, 182},
            new byte[] { 35,  83, 185}, new byte[] { 33,  85, 187}, new byte[] { 32,  88, 190}, new byte[] { 31,  91, 193},
            new byte[] { 29,  93, 195}, new byte[] { 28,  96, 198}, new byte[] { 27,  98, 201}, new byte[] { 25, 101, 203},
            new byte[] { 24, 104, 206}, new byte[] { 23, 107, 209}, new byte[] { 21, 109, 211}, new byte[] { 20, 112, 214},
            new byte[] { 19, 115, 217}, new byte[] { 17, 117, 219}, new byte[] { 16, 120, 222}, new byte[] { 14, 123, 225},
            new byte[] { 13, 125, 227}, new byte[] { 12, 128, 230}, new byte[] { 11, 131, 233}, new byte[] {  9, 133, 235},
            new byte[] {  8, 136, 238}, new byte[] {  7, 138, 241}, new byte[] {  5, 141, 243}, new byte[] {  4, 144, 246},
            new byte[] {  3, 147, 249}, new byte[] {  1, 149, 251}, new byte[] {  0, 152, 254}, new byte[] {  0, 154, 250},
            new byte[] {  0, 156, 244}, new byte[] {  0, 158, 238}, new byte[] {  0, 160, 232}, new byte[] {  0, 162, 226},
            new byte[] {  0, 164, 220}, new byte[] {  0, 166, 214}, new byte[] {  0, 168, 208}, new byte[] {  0, 170, 202},
            new byte[] {  0, 172, 196}, new byte[] {  0, 174, 190}, new byte[] {  0, 176, 184}, new byte[] {  0, 178, 178},
            new byte[] {  0, 180, 172}, new byte[] {  0, 182, 166}, new byte[] {  0, 184, 160}, new byte[] {  0, 186, 154},
            new byte[] {  0, 188, 148}, new byte[] {  0, 190, 142}, new byte[] {  0, 192, 136}, new byte[] {  0, 194, 130},
            new byte[] {  0, 196, 124}, new byte[] {  0, 198, 118}, new byte[] {  0, 200, 112}, new byte[] {  0, 202, 106},
            new byte[] {  1, 204, 102}, new byte[] {  5, 205, 103}, new byte[] {  8, 205, 103}, new byte[] { 13, 206, 104},
            new byte[] { 17, 207, 105}, new byte[] { 21, 208, 106}, new byte[] { 25, 209, 107}, new byte[] { 29, 209, 107},
            new byte[] { 33, 210, 108}, new byte[] { 37, 211, 109}, new byte[] { 40, 212, 110}, new byte[] { 45, 213, 111},
            new byte[] { 49, 213, 111}, new byte[] { 53, 214, 112}, new byte[] { 57, 215, 113}, new byte[] { 61, 216, 114},
            new byte[] { 65, 217, 115}, new byte[] { 69, 217, 115}, new byte[] { 72, 218, 116}, new byte[] { 77, 219, 117},
            new byte[] { 81, 220, 118}, new byte[] { 85, 221, 119}, new byte[] { 89, 221, 119}, new byte[] { 93, 222, 120},
            new byte[] { 97, 223, 121}, new byte[] {101, 224, 122}, new byte[] {104, 225, 122}, new byte[] {109, 225, 123},
            new byte[] {113, 226, 124}, new byte[] {117, 227, 125}, new byte[] {121, 228, 126}, new byte[] {125, 229, 127},
            new byte[] {129, 229, 127}, new byte[] {133, 230, 128}, new byte[] {136, 231, 129}, new byte[] {141, 232, 130},
            new byte[] {145, 233, 131}, new byte[] {149, 233, 131}, new byte[] {153, 234, 132}, new byte[] {157, 235, 133},
            new byte[] {161, 236, 134}, new byte[] {165, 237, 135}, new byte[] {168, 237, 135}, new byte[] {173, 238, 136},
            new byte[] {177, 239, 137}, new byte[] {181, 240, 138}, new byte[] {185, 241, 139}, new byte[] {189, 241, 139},
            new byte[] {193, 242, 140}, new byte[] {197, 243, 141}, new byte[] {200, 244, 142}, new byte[] {205, 245, 143},
            new byte[] {209, 245, 143}, new byte[] {213, 246, 144}, new byte[] {217, 247, 145}, new byte[] {221, 248, 146},
            new byte[] {225, 249, 147}, new byte[] {229, 249, 147}, new byte[] {232, 250, 148}, new byte[] {237, 251, 149},
            new byte[] {241, 252, 150}, new byte[] {245, 253, 151}, new byte[] {249, 253, 151}, new byte[] {253, 254, 152},
            new byte[] {254, 253, 152}, new byte[] {252, 251, 151}, new byte[] {250, 248, 150}, new byte[] {248, 246, 149},
            new byte[] {246, 243, 148}, new byte[] {244, 240, 147}, new byte[] {242, 238, 145}, new byte[] {240, 235, 144},
            new byte[] {238, 233, 143}, new byte[] {236, 230, 142}, new byte[] {234, 228, 141}, new byte[] {232, 225, 140},
            new byte[] {230, 223, 139}, new byte[] {228, 220, 138}, new byte[] {226, 217, 137}, new byte[] {224, 215, 136},
            new byte[] {222, 212, 135}, new byte[] {220, 210, 134}, new byte[] {218, 207, 133}, new byte[] {216, 205, 131},
            new byte[] {214, 202, 130}, new byte[] {211, 199, 129}, new byte[] {210, 197, 128}, new byte[] {208, 194, 127},
            new byte[] {206, 192, 126}, new byte[] {204, 189, 125}, new byte[] {202, 187, 124}, new byte[] {200, 184, 123},
            new byte[] {198, 182, 122}, new byte[] {195, 179, 121}, new byte[] {194, 176, 120}, new byte[] {192, 174, 118},
            new byte[] {190, 171, 117}, new byte[] {188, 169, 116}, new byte[] {186, 166, 115}, new byte[] {184, 164, 114},
            new byte[] {182, 161, 113}, new byte[] {179, 159, 112}, new byte[] {178, 156, 111}, new byte[] {176, 153, 110},
            new byte[] {174, 151, 109}, new byte[] {172, 148, 108}, new byte[] {170, 146, 107}, new byte[] {168, 143, 106},
            new byte[] {166, 141, 104}, new byte[] {163, 138, 103}, new byte[] {162, 135, 102}, new byte[] {160, 133, 101},
            new byte[] {158, 130, 100}, new byte[] {156, 128,  99}, new byte[] {154, 125,  98}, new byte[] {152, 123,  97},
            new byte[] {150, 120,  96}, new byte[] {147, 118,  95}, new byte[] {146, 115,  94}, new byte[] {144, 112,  93},
            new byte[] {142, 110,  91}, new byte[] {140, 107,  90}, new byte[] {138, 105,  89}, new byte[] {136, 102,  88},
            new byte[] {134, 100,  87}, new byte[] {131,  97,  86}, new byte[] {130,  95,  85}, new byte[] {128,  92,  84},
            new byte[] {129,  93,  86}, new byte[] {131,  96,  88}, new byte[] {133,  98,  91}, new byte[] {135, 101,  94},
            new byte[] {136, 103,  96}, new byte[] {139, 106,  99}, new byte[] {141, 109, 102}, new byte[] {143, 111, 104},
            new byte[] {145, 114, 107}, new byte[] {147, 116, 110}, new byte[] {149, 119, 112}, new byte[] {151, 121, 115},
            new byte[] {153, 124, 118}, new byte[] {155, 127, 121}, new byte[] {157, 129, 123}, new byte[] {159, 132, 126},
            new byte[] {161, 134, 129}, new byte[] {163, 137, 131}, new byte[] {165, 139, 134}, new byte[] {167, 142, 137},
            new byte[] {168, 144, 139}, new byte[] {171, 147, 142}, new byte[] {173, 150, 145}, new byte[] {175, 152, 147},
            new byte[] {177, 155, 150}, new byte[] {179, 157, 153}, new byte[] {181, 160, 155}, new byte[] {183, 162, 158},
            new byte[] {185, 165, 161}, new byte[] {187, 167, 163}, new byte[] {189, 170, 166}, new byte[] {191, 173, 169},
            new byte[] {193, 175, 171}, new byte[] {195, 178, 174}, new byte[] {196, 180, 177}, new byte[] {199, 183, 179},
            new byte[] {200, 185, 182}, new byte[] {203, 188, 185}, new byte[] {205, 191, 187}, new byte[] {207, 193, 190},
            new byte[] {209, 196, 193}, new byte[] {211, 198, 196}, new byte[] {212, 201, 198}, new byte[] {215, 203, 201},
            new byte[] {217, 206, 204}, new byte[] {219, 208, 206}, new byte[] {221, 211, 209}, new byte[] {223, 214, 212},
            new byte[] {225, 216, 214}, new byte[] {227, 219, 217}, new byte[] {228, 221, 220}, new byte[] {231, 224, 222},
            new byte[] {232, 226, 225}, new byte[] {235, 229, 228}, new byte[] {237, 231, 230}, new byte[] {239, 234, 233},
            new byte[] {241, 237, 236}, new byte[] {243, 239, 238}, new byte[] {244, 242, 241}, new byte[] {247, 244, 244},
            new byte[] {249, 247, 246}, new byte[] {251, 249, 249}, new byte[] {253, 252, 252}, new byte[] {255, 255, 255}
        });

        /// <summary>
        /// Colormap "viridis" taken from matplotlib
        /// </summary>
        public static readonly Lazy<byte[][]> Viridis = new Lazy<byte[][]>(() => new byte[][]
        {
            new byte[] { 68,   1,  84}, new byte[] { 68,   2,  85}, new byte[] { 68,   3,  87}, new byte[] { 69,   5,  88},
            new byte[] { 69,   6,  90}, new byte[] { 69,   8,  91}, new byte[] { 70,   9,  92}, new byte[] { 70,  11,  94},
            new byte[] { 70,  12,  95}, new byte[] { 70,  14,  97}, new byte[] { 71,  15,  98}, new byte[] { 71,  17,  99},
            new byte[] { 71,  18, 101}, new byte[] { 71,  20, 102}, new byte[] { 71,  21, 103}, new byte[] { 71,  22, 105},
            new byte[] { 71,  24, 106}, new byte[] { 72,  25, 107}, new byte[] { 72,  26, 108}, new byte[] { 72,  28, 110},
            new byte[] { 72,  29, 111}, new byte[] { 72,  30, 112}, new byte[] { 72,  32, 113}, new byte[] { 72,  33, 114},
            new byte[] { 72,  34, 115}, new byte[] { 72,  35, 116}, new byte[] { 71,  37, 117}, new byte[] { 71,  38, 118},
            new byte[] { 71,  39, 119}, new byte[] { 71,  40, 120}, new byte[] { 71,  42, 121}, new byte[] { 71,  43, 122},
            new byte[] { 71,  44, 123}, new byte[] { 70,  45, 124}, new byte[] { 70,  47, 124}, new byte[] { 70,  48, 125},
            new byte[] { 70,  49, 126}, new byte[] { 69,  50, 127}, new byte[] { 69,  52, 127}, new byte[] { 69,  53, 128},
            new byte[] { 69,  54, 129}, new byte[] { 68,  55, 129}, new byte[] { 68,  57, 130}, new byte[] { 67,  58, 131},
            new byte[] { 67,  59, 131}, new byte[] { 67,  60, 132}, new byte[] { 66,  61, 132}, new byte[] { 66,  62, 133},
            new byte[] { 66,  64, 133}, new byte[] { 65,  65, 134}, new byte[] { 65,  66, 134}, new byte[] { 64,  67, 135},
            new byte[] { 64,  68, 135}, new byte[] { 63,  69, 135}, new byte[] { 63,  71, 136}, new byte[] { 62,  72, 136},
            new byte[] { 62,  73, 137}, new byte[] { 61,  74, 137}, new byte[] { 61,  75, 137}, new byte[] { 61,  76, 137},
            new byte[] { 60,  77, 138}, new byte[] { 60,  78, 138}, new byte[] { 59,  80, 138}, new byte[] { 59,  81, 138},
            new byte[] { 58,  82, 139}, new byte[] { 58,  83, 139}, new byte[] { 57,  84, 139}, new byte[] { 57,  85, 139},
            new byte[] { 56,  86, 139}, new byte[] { 56,  87, 140}, new byte[] { 55,  88, 140}, new byte[] { 55,  89, 140},
            new byte[] { 54,  90, 140}, new byte[] { 54,  91, 140}, new byte[] { 53,  92, 140}, new byte[] { 53,  93, 140},
            new byte[] { 52,  94, 141}, new byte[] { 52,  95, 141}, new byte[] { 51,  96, 141}, new byte[] { 51,  97, 141},
            new byte[] { 50,  98, 141}, new byte[] { 50,  99, 141}, new byte[] { 49, 100, 141}, new byte[] { 49, 101, 141},
            new byte[] { 49, 102, 141}, new byte[] { 48, 103, 141}, new byte[] { 48, 104, 141}, new byte[] { 47, 105, 141},
            new byte[] { 47, 106, 141}, new byte[] { 46, 107, 142}, new byte[] { 46, 108, 142}, new byte[] { 46, 109, 142},
            new byte[] { 45, 110, 142}, new byte[] { 45, 111, 142}, new byte[] { 44, 112, 142}, new byte[] { 44, 113, 142},
            new byte[] { 44, 114, 142}, new byte[] { 43, 115, 142}, new byte[] { 43, 116, 142}, new byte[] { 42, 117, 142},
            new byte[] { 42, 118, 142}, new byte[] { 42, 119, 142}, new byte[] { 41, 120, 142}, new byte[] { 41, 121, 142},
            new byte[] { 40, 122, 142}, new byte[] { 40, 122, 142}, new byte[] { 40, 123, 142}, new byte[] { 39, 124, 142},
            new byte[] { 39, 125, 142}, new byte[] { 39, 126, 142}, new byte[] { 38, 127, 142}, new byte[] { 38, 128, 142},
            new byte[] { 38, 129, 142}, new byte[] { 37, 130, 142}, new byte[] { 37, 131, 141}, new byte[] { 36, 132, 141},
            new byte[] { 36, 133, 141}, new byte[] { 36, 134, 141}, new byte[] { 35, 135, 141}, new byte[] { 35, 136, 141},
            new byte[] { 35, 137, 141}, new byte[] { 34, 137, 141}, new byte[] { 34, 138, 141}, new byte[] { 34, 139, 141},
            new byte[] { 33, 140, 141}, new byte[] { 33, 141, 140}, new byte[] { 33, 142, 140}, new byte[] { 32, 143, 140},
            new byte[] { 32, 144, 140}, new byte[] { 32, 145, 140}, new byte[] { 31, 146, 140}, new byte[] { 31, 147, 139},
            new byte[] { 31, 148, 139}, new byte[] { 31, 149, 139}, new byte[] { 31, 150, 139}, new byte[] { 30, 151, 138},
            new byte[] { 30, 152, 138}, new byte[] { 30, 153, 138}, new byte[] { 30, 153, 138}, new byte[] { 30, 154, 137},
            new byte[] { 30, 155, 137}, new byte[] { 30, 156, 137}, new byte[] { 30, 157, 136}, new byte[] { 30, 158, 136},
            new byte[] { 30, 159, 136}, new byte[] { 30, 160, 135}, new byte[] { 31, 161, 135}, new byte[] { 31, 162, 134},
            new byte[] { 31, 163, 134}, new byte[] { 32, 164, 133}, new byte[] { 32, 165, 133}, new byte[] { 33, 166, 133},
            new byte[] { 33, 167, 132}, new byte[] { 34, 167, 132}, new byte[] { 35, 168, 131}, new byte[] { 35, 169, 130},
            new byte[] { 36, 170, 130}, new byte[] { 37, 171, 129}, new byte[] { 38, 172, 129}, new byte[] { 39, 173, 128},
            new byte[] { 40, 174, 127}, new byte[] { 41, 175, 127}, new byte[] { 42, 176, 126}, new byte[] { 43, 177, 125},
            new byte[] { 44, 177, 125}, new byte[] { 46, 178, 124}, new byte[] { 47, 179, 123}, new byte[] { 48, 180, 122},
            new byte[] { 50, 181, 122}, new byte[] { 51, 182, 121}, new byte[] { 53, 183, 120}, new byte[] { 54, 184, 119},
            new byte[] { 56, 185, 118}, new byte[] { 57, 185, 118}, new byte[] { 59, 186, 117}, new byte[] { 61, 187, 116},
            new byte[] { 62, 188, 115}, new byte[] { 64, 189, 114}, new byte[] { 66, 190, 113}, new byte[] { 68, 190, 112},
            new byte[] { 69, 191, 111}, new byte[] { 71, 192, 110}, new byte[] { 73, 193, 109}, new byte[] { 75, 194, 108},
            new byte[] { 77, 194, 107}, new byte[] { 79, 195, 105}, new byte[] { 81, 196, 104}, new byte[] { 83, 197, 103},
            new byte[] { 85, 198, 102}, new byte[] { 87, 198, 101}, new byte[] { 89, 199, 100}, new byte[] { 91, 200,  98},
            new byte[] { 94, 201,  97}, new byte[] { 96, 201,  96}, new byte[] { 98, 202,  95}, new byte[] {100, 203,  93},
            new byte[] {103, 204,  92}, new byte[] {105, 204,  91}, new byte[] {107, 205,  89}, new byte[] {109, 206,  88},
            new byte[] {112, 206,  86}, new byte[] {114, 207,  85}, new byte[] {116, 208,  84}, new byte[] {119, 208,  82},
            new byte[] {121, 209,  81}, new byte[] {124, 210,  79}, new byte[] {126, 210,  78}, new byte[] {129, 211,  76},
            new byte[] {131, 211,  75}, new byte[] {134, 212,  73}, new byte[] {136, 213,  71}, new byte[] {139, 213,  70},
            new byte[] {141, 214,  68}, new byte[] {144, 214,  67}, new byte[] {146, 215,  65}, new byte[] {149, 215,  63},
            new byte[] {151, 216,  62}, new byte[] {154, 216,  60}, new byte[] {157, 217,  58}, new byte[] {159, 217,  56},
            new byte[] {162, 218,  55}, new byte[] {165, 218,  53}, new byte[] {167, 219,  51}, new byte[] {170, 219,  50},
            new byte[] {173, 220,  48}, new byte[] {175, 220,  46}, new byte[] {178, 221,  44}, new byte[] {181, 221,  43},
            new byte[] {183, 221,  41}, new byte[] {186, 222,  39}, new byte[] {189, 222,  38}, new byte[] {191, 223,  36},
            new byte[] {194, 223,  34}, new byte[] {197, 223,  33}, new byte[] {199, 224,  31}, new byte[] {202, 224,  30},
            new byte[] {205, 224,  29}, new byte[] {207, 225,  28}, new byte[] {210, 225,  27}, new byte[] {212, 225,  26},
            new byte[] {215, 226,  25}, new byte[] {218, 226,  24}, new byte[] {220, 226,  24}, new byte[] {223, 227,  24},
            new byte[] {225, 227,  24}, new byte[] {228, 227,  24}, new byte[] {231, 228,  25}, new byte[] {233, 228,  25},
            new byte[] {236, 228,  26}, new byte[] {238, 229,  27}, new byte[] {241, 229,  28}, new byte[] {243, 229,  30},
            new byte[] {246, 230,  31}, new byte[] {248, 230,  33}, new byte[] {250, 230,  34}, new byte[] {253, 231,  36}
        });

    #endregion

        /// <summary>
        /// Convenient dictionary for mapping palette names onto palette byte arrays
        /// </summary>
        public static readonly Dictionary<string, Lazy<byte[][]>>
            ByName = new Dictionary<string, Lazy<byte[][]>>
        {
            { "afmhot", Afmhot },
            { "gist_earth", GistEarth },
            { "inferno", Inferno },
            { "terrain", Terrain },
            { "viridis", Viridis }
        };

        /// <summary>
        /// Enumerate all available palettes / colormaps
        /// </summary>
        public static IEnumerable<string> Names
        {
            get { return ByName.Keys; }
        }
    }

#else
    public static class Palette
    {
        /// <summary>
        /// Number of base colors in palette
        /// </summary>
        public const int Resolution = 256;

        #region palettes

        /// <summary>
        /// Colormap "afmhot" taken from matplotlib
        /// </summary>
        public static readonly Lazy<byte[,]> Afmhot = new Lazy<byte[,]>(() => new byte[,]
        {
            {  0,   0,   0}, {  2,   0,   0}, {  4,   0,   0}, {  6,   0,   0},
            {  8,   0,   0}, { 10,   0,   0}, { 12,   0,   0}, { 14,   0,   0},
            { 16,   0,   0}, { 18,   0,   0}, { 20,   0,   0}, { 22,   0,   0},
            { 24,   0,   0}, { 26,   0,   0}, { 28,   0,   0}, { 30,   0,   0},
            { 32,   0,   0}, { 34,   0,   0}, { 36,   0,   0}, { 38,   0,   0},
            { 40,   0,   0}, { 42,   0,   0}, { 44,   0,   0}, { 46,   0,   0},
            { 48,   0,   0}, { 50,   0,   0}, { 52,   0,   0}, { 54,   0,   0},
            { 56,   0,   0}, { 58,   0,   0}, { 60,   0,   0}, { 62,   0,   0},
            { 64,   0,   0}, { 65,   0,   0}, { 68,   0,   0}, { 70,   0,   0},
            { 72,   0,   0}, { 73,   0,   0}, { 76,   0,   0}, { 78,   0,   0},
            { 80,   0,   0}, { 81,   0,   0}, { 84,   0,   0}, { 86,   0,   0},
            { 88,   0,   0}, { 89,   0,   0}, { 92,   0,   0}, { 94,   0,   0},
            { 96,   0,   0}, { 97,   0,   0}, {100,   0,   0}, {102,   0,   0},
            {104,   0,   0}, {105,   0,   0}, {108,   0,   0}, {110,   0,   0},
            {112,   0,   0}, {113,   0,   0}, {116,   0,   0}, {118,   0,   0},
            {120,   0,   0}, {121,   0,   0}, {124,   0,   0}, {126,   0,   0},
            {128,   0,   0}, {130,   2,   0}, {131,   4,   0}, {134,   6,   0},
            {136,   8,   0}, {138,  10,   0}, {140,  12,   0}, {142,  14,   0},
            {144,  16,   0}, {146,  18,   0}, {147,  20,   0}, {150,  22,   0},
            {152,  24,   0}, {154,  26,   0}, {156,  28,   0}, {158,  30,   0},
            {160,  32,   0}, {162,  34,   0}, {163,  36,   0}, {166,  38,   0},
            {168,  40,   0}, {170,  42,   0}, {172,  44,   0}, {174,  46,   0},
            {176,  48,   0}, {178,  50,   0}, {179,  52,   0}, {182,  54,   0},
            {184,  56,   0}, {186,  58,   0}, {188,  60,   0}, {190,  62,   0},
            {192,  64,   0}, {194,  66,   0}, {195,  68,   0}, {198,  70,   0},
            {200,  72,   0}, {202,  74,   0}, {204,  76,   0}, {206,  78,   0},
            {208,  80,   0}, {210,  82,   0}, {211,  84,   0}, {214,  86,   0},
            {216,  88,   0}, {218,  90,   0}, {220,  92,   0}, {222,  94,   0},
            {224,  96,   0}, {226,  98,   0}, {227, 100,   0}, {230, 102,   0},
            {232, 104,   0}, {234, 106,   0}, {236, 108,   0}, {238, 110,   0},
            {240, 112,   0}, {242, 114,   0}, {243, 116,   0}, {246, 118,   0},
            {248, 120,   0}, {250, 122,   0}, {252, 124,   0}, {254, 126,   0},
            {255, 128,   0}, {255, 130,   2}, {255, 132,   4}, {255, 134,   6},
            {255, 136,   8}, {255, 138,  11}, {255, 140,  13}, {255, 142,  15},
            {255, 144,  16}, {255, 146,  18}, {255, 148,  20}, {255, 150,  22},
            {255, 152,  25}, {255, 154,  27}, {255, 156,  29}, {255, 158,  31},
            {255, 160,  32}, {255, 162,  34}, {255, 164,  36}, {255, 166,  38},
            {255, 168,  40}, {255, 170,  43}, {255, 172,  45}, {255, 174,  47},
            {255, 176,  48}, {255, 178,  50}, {255, 180,  52}, {255, 182,  54},
            {255, 184,  57}, {255, 186,  59}, {255, 188,  61}, {255, 190,  63},
            {255, 192,  65}, {255, 194,  66}, {255, 196,  68}, {255, 198,  70},
            {255, 200,  72}, {255, 202,  75}, {255, 204,  77}, {255, 206,  79},
            {255, 208,  81}, {255, 210,  82}, {255, 212,  84}, {255, 214,  86},
            {255, 216,  89}, {255, 218,  91}, {255, 220,  93}, {255, 222,  95},
            {255, 224,  97}, {255, 226,  98}, {255, 228, 100}, {255, 230, 102},
            {255, 232, 104}, {255, 234, 107}, {255, 236, 109}, {255, 238, 111},
            {255, 240, 113}, {255, 242, 114}, {255, 244, 116}, {255, 246, 118},
            {255, 248, 121}, {255, 250, 123}, {255, 252, 125}, {255, 254, 127},
            {255, 255, 129}, {255, 255, 131}, {255, 255, 132}, {255, 255, 134},
            {255, 255, 136}, {255, 255, 139}, {255, 255, 141}, {255, 255, 143},
            {255, 255, 145}, {255, 255, 147}, {255, 255, 148}, {255, 255, 150},
            {255, 255, 153}, {255, 255, 155}, {255, 255, 157}, {255, 255, 159},
            {255, 255, 161}, {255, 255, 163}, {255, 255, 164}, {255, 255, 166},
            {255, 255, 168}, {255, 255, 171}, {255, 255, 173}, {255, 255, 175},
            {255, 255, 177}, {255, 255, 179}, {255, 255, 180}, {255, 255, 182},
            {255, 255, 185}, {255, 255, 187}, {255, 255, 189}, {255, 255, 191},
            {255, 255, 193}, {255, 255, 195}, {255, 255, 196}, {255, 255, 198},
            {255, 255, 200}, {255, 255, 203}, {255, 255, 205}, {255, 255, 207},
            {255, 255, 209}, {255, 255, 211}, {255, 255, 212}, {255, 255, 214},
            {255, 255, 217}, {255, 255, 219}, {255, 255, 221}, {255, 255, 223},
            {255, 255, 225}, {255, 255, 227}, {255, 255, 228}, {255, 255, 230},
            {255, 255, 232}, {255, 255, 235}, {255, 255, 237}, {255, 255, 239},
            {255, 255, 241}, {255, 255, 243}, {255, 255, 244}, {255, 255, 246},
            {255, 255, 249}, {255, 255, 251}, {255, 255, 253}, {255, 255, 255}
        });

        /// <summary>
        /// Colormap "gist_earth" taken from matplotlib
        /// </summary>
        public static readonly Lazy<byte[,]> GistEarth = new Lazy<byte[,]>(() => new byte[,]
        {
            {  0,   0,   0}, {  0,   0,  43}, {  1,   0,  56}, {  1,   0,  67},
            {  2,   0,  78}, {  3,   0,  88}, {  3,   0,  99}, {  4,   0, 110},
            {  5,   2, 115}, {  5,   4, 116}, {  6,   6, 116}, {  7,   9, 116},
            {  7,  11, 116}, {  8,  13, 116}, {  9,  16, 117}, {  9,  18, 117},
            { 10,  20, 117}, { 11,  22, 117}, { 11,  25, 117}, { 12,  27, 117},
            { 13,  29, 118}, { 13,  32, 118}, { 14,  34, 118}, { 15,  36, 118},
            { 15,  39, 118}, { 16,  41, 119}, { 17,  43, 119}, { 17,  45, 119},
            { 18,  48, 119}, { 19,  50, 119}, { 19,  52, 119}, { 20,  54, 120},
            { 21,  56, 120}, { 21,  58, 120}, { 22,  60, 120}, { 23,  62, 120},
            { 23,  64, 121}, { 24,  66, 121}, { 25,  69, 121}, { 25,  71, 121},
            { 26,  73, 121}, { 27,  75, 121}, { 27,  77, 122}, { 28,  79, 122},
            { 29,  81, 122}, { 29,  83, 122}, { 30,  84, 122}, { 31,  86, 123},
            { 31,  88, 123}, { 32,  90, 123}, { 33,  92, 123}, { 33,  94, 123},
            { 34,  96, 123}, { 35,  97, 124}, { 35,  99, 124}, { 36, 101, 124},
            { 37, 102, 124}, { 37, 104, 124}, { 38, 105, 125}, { 39, 107, 125},
            { 39, 109, 125}, { 40, 110, 125}, { 41, 112, 125}, { 41, 113, 125},
            { 42, 115, 126}, { 43, 116, 126}, { 43, 118, 126}, { 44, 120, 126},
            { 45, 121, 126}, { 45, 123, 127}, { 46, 124, 127}, { 47, 126, 127},
            { 47, 127, 127}, { 48, 128, 126}, { 48, 129, 125}, { 49, 129, 123},
            { 49, 130, 122}, { 50, 130, 121}, { 50, 131, 120}, { 51, 132, 119},
            { 51, 132, 117}, { 52, 133, 116}, { 52, 133, 115}, { 53, 134, 114},
            { 53, 134, 112}, { 54, 135, 111}, { 54, 136, 110}, { 55, 136, 109},
            { 55, 137, 108}, { 56, 137, 106}, { 56, 138, 105}, { 56, 138, 104},
            { 57, 139, 103}, { 57, 140, 101}, { 58, 140, 100}, { 58, 141,  99},
            { 59, 141,  98}, { 59, 142,  97}, { 60, 142,  95}, { 60, 143,  94},
            { 61, 144,  93}, { 61, 144,  92}, { 62, 145,  90}, { 62, 145,  89},
            { 63, 146,  88}, { 63, 147,  87}, { 64, 147,  85}, { 64, 148,  84},
            { 64, 148,  83}, { 65, 149,  82}, { 65, 149,  81}, { 66, 150,  79},
            { 66, 151,  78}, { 67, 151,  77}, { 67, 152,  76}, { 68, 152,  74},
            { 68, 153,  73}, { 69, 153,  72}, { 71, 154,  71}, { 73, 155,  70},
            { 75, 155,  70}, { 78, 156,  71}, { 80, 156,  71}, { 82, 157,  72},
            { 84, 157,  72}, { 87, 158,  73}, { 89, 159,  74}, { 91, 159,  74},
            { 93, 160,  75}, { 95, 160,  75}, { 98, 161,  76}, {100, 161,  77},
            {102, 162,  77}, {104, 163,  78}, {107, 163,  78}, {109, 163,  79},
            {111, 164,  79}, {113, 164,  80}, {115, 165,  81}, {118, 165,  81},
            {120, 166,  82}, {121, 166,  82}, {123, 167,  82}, {125, 167,  82},
            {126, 167,  83}, {128, 168,  83}, {130, 168,  83}, {131, 169,  84},
            {133, 169,  84}, {135, 170,  84}, {136, 170,  85}, {138, 171,  85},
            {140, 171,  85}, {141, 171,  86}, {143, 172,  86}, {145, 172,  86},
            {146, 173,  87}, {148, 173,  87}, {150, 174,  87}, {151, 174,  88},
            {153, 174,  88}, {154, 175,  88}, {156, 175,  88}, {158, 176,  89},
            {159, 176,  89}, {161, 177,  89}, {163, 177,  90}, {164, 178,  90},
            {166, 178,  90}, {168, 178,  91}, {169, 179,  91}, {171, 179,  91},
            {173, 180,  92}, {174, 180,  92}, {176, 181,  92}, {178, 181,  93},
            {179, 181,  93}, {181, 182,  93}, {182, 182,  94}, {183, 181,  94},
            {183, 181,  94}, {184, 180,  95}, {184, 179,  95}, {185, 178,  95},
            {185, 177,  95}, {185, 176,  96}, {186, 175,  96}, {186, 175,  96},
            {187, 174,  97}, {187, 173,  97}, {188, 172,  97}, {188, 171,  98},
            {188, 170,  98}, {189, 169,  98}, {189, 169,  99}, {190, 168,  99},
            {190, 167,  99}, {190, 166, 100}, {191, 165, 100}, {191, 164, 100},
            {192, 163, 101}, {192, 163, 103}, {193, 163, 105}, {194, 163, 108},
            {195, 164, 110}, {197, 164, 113}, {198, 165, 115}, {199, 166, 118},
            {200, 166, 120}, {201, 167, 123}, {202, 168, 125}, {203, 169, 127},
            {204, 170, 130}, {206, 171, 132}, {207, 172, 135}, {208, 173, 137},
            {209, 173, 140}, {210, 174, 142}, {211, 175, 145}, {212, 176, 147},
            {213, 177, 150}, {214, 178, 152}, {216, 179, 154}, {217, 181, 157},
            {218, 182, 159}, {219, 183, 162}, {220, 185, 164}, {221, 186, 167},
            {222, 188, 169}, {223, 189, 172}, {225, 191, 175}, {226, 193, 178},
            {227, 195, 181}, {228, 197, 184}, {229, 199, 187}, {230, 201, 190},
            {231, 203, 193}, {232, 205, 196}, {233, 207, 199}, {235, 209, 202},
            {236, 211, 205}, {237, 213, 208}, {238, 215, 211}, {239, 217, 214},
            {240, 220, 217}, {241, 222, 220}, {242, 224, 223}, {244, 227, 226},
            {245, 230, 229}, {246, 233, 232}, {247, 236, 235}, {248, 239, 238},
            {249, 242, 241}, {250, 245, 244}, {251, 248, 247}, {253, 250, 250}
        });

        /// <summary>
        /// Colormap "inferno" taken from matplotlib
        /// </summary>
        public static readonly Lazy<byte[,]> Inferno = new Lazy<byte[,]>(() => new byte[,]
        {
            {  0,   0,   3}, {  0,   0,   4}, {  0,   0,   6}, {  1,   0,   7},
            {  1,   1,   9}, {  1,   1,  11}, {  2,   1,  14}, {  2,   2,  16},
            {  3,   2,  18}, {  4,   3,  20}, {  4,   3,  22}, {  5,   4,  24},
            {  6,   4,  27}, {  7,   5,  29}, {  8,   6,  31}, {  9,   6,  33},
            { 10,   7,  35}, { 11,   7,  38}, { 13,   8,  40}, { 14,   8,  42},
            { 15,   9,  45}, { 16,   9,  47}, { 18,  10,  50}, { 19,  10,  52},
            { 20,  11,  54}, { 22,  11,  57}, { 23,  11,  59}, { 25,  11,  62},
            { 26,  11,  64}, { 28,  12,  67}, { 29,  12,  69}, { 31,  12,  71},
            { 32,  12,  74}, { 34,  11,  76}, { 36,  11,  78}, { 38,  11,  80},
            { 39,  11,  82}, { 41,  11,  84}, { 43,  10,  86}, { 45,  10,  88},
            { 46,  10,  90}, { 48,  10,  92}, { 50,   9,  93}, { 52,   9,  95},
            { 53,   9,  96}, { 55,   9,  97}, { 57,   9,  98}, { 59,   9, 100},
            { 60,   9, 101}, { 62,   9, 102}, { 64,   9, 102}, { 65,   9, 103},
            { 67,  10, 104}, { 69,  10, 105}, { 70,  10, 105}, { 72,  11, 106},
            { 74,  11, 106}, { 75,  12, 107}, { 77,  12, 107}, { 79,  13, 108},
            { 80,  13, 108}, { 82,  14, 108}, { 83,  14, 109}, { 85,  15, 109},
            { 87,  15, 109}, { 88,  16, 109}, { 90,  17, 109}, { 91,  17, 110},
            { 93,  18, 110}, { 95,  18, 110}, { 96,  19, 110}, { 98,  20, 110},
            { 99,  20, 110}, {101,  21, 110}, {102,  21, 110}, {104,  22, 110},
            {106,  23, 110}, {107,  23, 110}, {109,  24, 110}, {110,  24, 110},
            {112,  25, 110}, {114,  25, 109}, {115,  26, 109}, {117,  27, 109},
            {118,  27, 109}, {120,  28, 109}, {122,  28, 109}, {123,  29, 108},
            {125,  29, 108}, {126,  30, 108}, {128,  31, 107}, {129,  31, 107},
            {131,  32, 107}, {133,  32, 106}, {134,  33, 106}, {136,  33, 106},
            {137,  34, 105}, {139,  34, 105}, {141,  35, 105}, {142,  36, 104},
            {144,  36, 104}, {145,  37, 103}, {147,  37, 103}, {149,  38, 102},
            {150,  38, 102}, {152,  39, 101}, {153,  40, 100}, {155,  40, 100},
            {156,  41,  99}, {158,  41,  99}, {160,  42,  98}, {161,  43,  97},
            {163,  43,  97}, {164,  44,  96}, {166,  44,  95}, {167,  45,  95},
            {169,  46,  94}, {171,  46,  93}, {172,  47,  92}, {174,  48,  91},
            {175,  49,  91}, {177,  49,  90}, {178,  50,  89}, {180,  51,  88},
            {181,  51,  87}, {183,  52,  86}, {184,  53,  86}, {186,  54,  85},
            {187,  55,  84}, {189,  55,  83}, {190,  56,  82}, {191,  57,  81},
            {193,  58,  80}, {194,  59,  79}, {196,  60,  78}, {197,  61,  77},
            {199,  62,  76}, {200,  62,  75}, {201,  63,  74}, {203,  64,  73},
            {204,  65,  72}, {205,  66,  71}, {207,  68,  70}, {208,  69,  68},
            {209,  70,  67}, {210,  71,  66}, {212,  72,  65}, {213,  73,  64},
            {214,  74,  63}, {215,  75,  62}, {217,  77,  61}, {218,  78,  59},
            {219,  79,  58}, {220,  80,  57}, {221,  82,  56}, {222,  83,  55},
            {223,  84,  54}, {224,  86,  52}, {226,  87,  51}, {227,  88,  50},
            {228,  90,  49}, {229,  91,  48}, {230,  92,  46}, {230,  94,  45},
            {231,  95,  44}, {232,  97,  43}, {233,  98,  42}, {234, 100,  40},
            {235, 101,  39}, {236, 103,  38}, {237, 104,  37}, {237, 106,  35},
            {238, 108,  34}, {239, 109,  33}, {240, 111,  31}, {240, 112,  30},
            {241, 114,  29}, {242, 116,  28}, {242, 117,  26}, {243, 119,  25},
            {243, 121,  24}, {244, 122,  22}, {245, 124,  21}, {245, 126,  20},
            {246, 128,  18}, {246, 129,  17}, {247, 131,  16}, {247, 133,  14},
            {248, 135,  13}, {248, 136,  12}, {248, 138,  11}, {249, 140,   9},
            {249, 142,   8}, {249, 144,   8}, {250, 145,   7}, {250, 147,   6},
            {250, 149,   6}, {250, 151,   6}, {251, 153,   6}, {251, 155,   6},
            {251, 157,   6}, {251, 158,   7}, {251, 160,   7}, {251, 162,   8},
            {251, 164,  10}, {251, 166,  11}, {251, 168,  13}, {251, 170,  14},
            {251, 172,  16}, {251, 174,  18}, {251, 176,  20}, {251, 177,  22},
            {251, 179,  24}, {251, 181,  26}, {251, 183,  28}, {251, 185,  30},
            {250, 187,  33}, {250, 189,  35}, {250, 191,  37}, {250, 193,  40},
            {249, 195,  42}, {249, 197,  44}, {249, 199,  47}, {248, 201,  49},
            {248, 203,  52}, {248, 205,  55}, {247, 207,  58}, {247, 209,  60},
            {246, 211,  63}, {246, 213,  66}, {245, 215,  69}, {245, 217,  72},
            {244, 219,  75}, {244, 220,  79}, {243, 222,  82}, {243, 224,  86},
            {243, 226,  89}, {242, 228,  93}, {242, 230,  96}, {241, 232, 100},
            {241, 233, 104}, {241, 235, 108}, {241, 237, 112}, {241, 238, 116},
            {241, 240, 121}, {241, 242, 125}, {242, 243, 129}, {242, 244, 133},
            {243, 246, 137}, {244, 247, 141}, {245, 248, 145}, {246, 250, 149},
            {247, 251, 153}, {249, 252, 157}, {250, 253, 160}, {252, 254, 164}
        });

        /// <summary>
        /// Colormap "terrain" taken from matplotlib
        /// </summary>
        public static readonly Lazy<byte[,]> Terrain = new Lazy<byte[,]>(() => new byte[,]
        {
            { 51,  51, 153}, { 49,  53, 155}, { 48,  56, 158}, { 47,  59, 161},
            { 45,  61, 163}, { 44,  64, 166}, { 43,  67, 169}, { 41,  69, 171},
            { 40,  72, 174}, { 39,  75, 177}, { 37,  77, 179}, { 36,  80, 182},
            { 35,  83, 185}, { 33,  85, 187}, { 32,  88, 190}, { 31,  91, 193},
            { 29,  93, 195}, { 28,  96, 198}, { 27,  98, 201}, { 25, 101, 203},
            { 24, 104, 206}, { 23, 107, 209}, { 21, 109, 211}, { 20, 112, 214},
            { 19, 115, 217}, { 17, 117, 219}, { 16, 120, 222}, { 14, 123, 225},
            { 13, 125, 227}, { 12, 128, 230}, { 11, 131, 233}, {  9, 133, 235},
            {  8, 136, 238}, {  7, 138, 241}, {  5, 141, 243}, {  4, 144, 246},
            {  3, 147, 249}, {  1, 149, 251}, {  0, 152, 254}, {  0, 154, 250},
            {  0, 156, 244}, {  0, 158, 238}, {  0, 160, 232}, {  0, 162, 226},
            {  0, 164, 220}, {  0, 166, 214}, {  0, 168, 208}, {  0, 170, 202},
            {  0, 172, 196}, {  0, 174, 190}, {  0, 176, 184}, {  0, 178, 178},
            {  0, 180, 172}, {  0, 182, 166}, {  0, 184, 160}, {  0, 186, 154},
            {  0, 188, 148}, {  0, 190, 142}, {  0, 192, 136}, {  0, 194, 130},
            {  0, 196, 124}, {  0, 198, 118}, {  0, 200, 112}, {  0, 202, 106},
            {  1, 204, 102}, {  5, 205, 103}, {  8, 205, 103}, { 13, 206, 104},
            { 17, 207, 105}, { 21, 208, 106}, { 25, 209, 107}, { 29, 209, 107},
            { 33, 210, 108}, { 37, 211, 109}, { 40, 212, 110}, { 45, 213, 111},
            { 49, 213, 111}, { 53, 214, 112}, { 57, 215, 113}, { 61, 216, 114},
            { 65, 217, 115}, { 69, 217, 115}, { 72, 218, 116}, { 77, 219, 117},
            { 81, 220, 118}, { 85, 221, 119}, { 89, 221, 119}, { 93, 222, 120},
            { 97, 223, 121}, {101, 224, 122}, {104, 225, 122}, {109, 225, 123},
            {113, 226, 124}, {117, 227, 125}, {121, 228, 126}, {125, 229, 127},
            {129, 229, 127}, {133, 230, 128}, {136, 231, 129}, {141, 232, 130},
            {145, 233, 131}, {149, 233, 131}, {153, 234, 132}, {157, 235, 133},
            {161, 236, 134}, {165, 237, 135}, {168, 237, 135}, {173, 238, 136},
            {177, 239, 137}, {181, 240, 138}, {185, 241, 139}, {189, 241, 139},
            {193, 242, 140}, {197, 243, 141}, {200, 244, 142}, {205, 245, 143},
            {209, 245, 143}, {213, 246, 144}, {217, 247, 145}, {221, 248, 146},
            {225, 249, 147}, {229, 249, 147}, {232, 250, 148}, {237, 251, 149},
            {241, 252, 150}, {245, 253, 151}, {249, 253, 151}, {253, 254, 152},
            {254, 253, 152}, {252, 251, 151}, {250, 248, 150}, {248, 246, 149},
            {246, 243, 148}, {244, 240, 147}, {242, 238, 145}, {240, 235, 144},
            {238, 233, 143}, {236, 230, 142}, {234, 228, 141}, {232, 225, 140},
            {230, 223, 139}, {228, 220, 138}, {226, 217, 137}, {224, 215, 136},
            {222, 212, 135}, {220, 210, 134}, {218, 207, 133}, {216, 205, 131},
            {214, 202, 130}, {211, 199, 129}, {210, 197, 128}, {208, 194, 127},
            {206, 192, 126}, {204, 189, 125}, {202, 187, 124}, {200, 184, 123},
            {198, 182, 122}, {195, 179, 121}, {194, 176, 120}, {192, 174, 118},
            {190, 171, 117}, {188, 169, 116}, {186, 166, 115}, {184, 164, 114},
            {182, 161, 113}, {179, 159, 112}, {178, 156, 111}, {176, 153, 110},
            {174, 151, 109}, {172, 148, 108}, {170, 146, 107}, {168, 143, 106},
            {166, 141, 104}, {163, 138, 103}, {162, 135, 102}, {160, 133, 101},
            {158, 130, 100}, {156, 128,  99}, {154, 125,  98}, {152, 123,  97},
            {150, 120,  96}, {147, 118,  95}, {146, 115,  94}, {144, 112,  93},
            {142, 110,  91}, {140, 107,  90}, {138, 105,  89}, {136, 102,  88},
            {134, 100,  87}, {131,  97,  86}, {130,  95,  85}, {128,  92,  84},
            {129,  93,  86}, {131,  96,  88}, {133,  98,  91}, {135, 101,  94},
            {136, 103,  96}, {139, 106,  99}, {141, 109, 102}, {143, 111, 104},
            {145, 114, 107}, {147, 116, 110}, {149, 119, 112}, {151, 121, 115},
            {153, 124, 118}, {155, 127, 121}, {157, 129, 123}, {159, 132, 126},
            {161, 134, 129}, {163, 137, 131}, {165, 139, 134}, {167, 142, 137},
            {168, 144, 139}, {171, 147, 142}, {173, 150, 145}, {175, 152, 147},
            {177, 155, 150}, {179, 157, 153}, {181, 160, 155}, {183, 162, 158},
            {185, 165, 161}, {187, 167, 163}, {189, 170, 166}, {191, 173, 169},
            {193, 175, 171}, {195, 178, 174}, {196, 180, 177}, {199, 183, 179},
            {200, 185, 182}, {203, 188, 185}, {205, 191, 187}, {207, 193, 190},
            {209, 196, 193}, {211, 198, 196}, {212, 201, 198}, {215, 203, 201},
            {217, 206, 204}, {219, 208, 206}, {221, 211, 209}, {223, 214, 212},
            {225, 216, 214}, {227, 219, 217}, {228, 221, 220}, {231, 224, 222},
            {232, 226, 225}, {235, 229, 228}, {237, 231, 230}, {239, 234, 233},
            {241, 237, 236}, {243, 239, 238}, {244, 242, 241}, {247, 244, 244},
            {249, 247, 246}, {251, 249, 249}, {253, 252, 252}, {255, 255, 255}
        });

        /// <summary>
        /// Colormap "viridis" taken from matplotlib
        /// </summary>
        public static readonly Lazy<byte[,]> Viridis = new Lazy<byte[,]>(() => new byte[,]
        {
            { 68,   1,  84}, { 68,   2,  85}, { 68,   3,  87}, { 69,   5,  88},
            { 69,   6,  90}, { 69,   8,  91}, { 70,   9,  92}, { 70,  11,  94},
            { 70,  12,  95}, { 70,  14,  97}, { 71,  15,  98}, { 71,  17,  99},
            { 71,  18, 101}, { 71,  20, 102}, { 71,  21, 103}, { 71,  22, 105},
            { 71,  24, 106}, { 72,  25, 107}, { 72,  26, 108}, { 72,  28, 110},
            { 72,  29, 111}, { 72,  30, 112}, { 72,  32, 113}, { 72,  33, 114},
            { 72,  34, 115}, { 72,  35, 116}, { 71,  37, 117}, { 71,  38, 118},
            { 71,  39, 119}, { 71,  40, 120}, { 71,  42, 121}, { 71,  43, 122},
            { 71,  44, 123}, { 70,  45, 124}, { 70,  47, 124}, { 70,  48, 125},
            { 70,  49, 126}, { 69,  50, 127}, { 69,  52, 127}, { 69,  53, 128},
            { 69,  54, 129}, { 68,  55, 129}, { 68,  57, 130}, { 67,  58, 131},
            { 67,  59, 131}, { 67,  60, 132}, { 66,  61, 132}, { 66,  62, 133},
            { 66,  64, 133}, { 65,  65, 134}, { 65,  66, 134}, { 64,  67, 135},
            { 64,  68, 135}, { 63,  69, 135}, { 63,  71, 136}, { 62,  72, 136},
            { 62,  73, 137}, { 61,  74, 137}, { 61,  75, 137}, { 61,  76, 137},
            { 60,  77, 138}, { 60,  78, 138}, { 59,  80, 138}, { 59,  81, 138},
            { 58,  82, 139}, { 58,  83, 139}, { 57,  84, 139}, { 57,  85, 139},
            { 56,  86, 139}, { 56,  87, 140}, { 55,  88, 140}, { 55,  89, 140},
            { 54,  90, 140}, { 54,  91, 140}, { 53,  92, 140}, { 53,  93, 140},
            { 52,  94, 141}, { 52,  95, 141}, { 51,  96, 141}, { 51,  97, 141},
            { 50,  98, 141}, { 50,  99, 141}, { 49, 100, 141}, { 49, 101, 141},
            { 49, 102, 141}, { 48, 103, 141}, { 48, 104, 141}, { 47, 105, 141},
            { 47, 106, 141}, { 46, 107, 142}, { 46, 108, 142}, { 46, 109, 142},
            { 45, 110, 142}, { 45, 111, 142}, { 44, 112, 142}, { 44, 113, 142},
            { 44, 114, 142}, { 43, 115, 142}, { 43, 116, 142}, { 42, 117, 142},
            { 42, 118, 142}, { 42, 119, 142}, { 41, 120, 142}, { 41, 121, 142},
            { 40, 122, 142}, { 40, 122, 142}, { 40, 123, 142}, { 39, 124, 142},
            { 39, 125, 142}, { 39, 126, 142}, { 38, 127, 142}, { 38, 128, 142},
            { 38, 129, 142}, { 37, 130, 142}, { 37, 131, 141}, { 36, 132, 141},
            { 36, 133, 141}, { 36, 134, 141}, { 35, 135, 141}, { 35, 136, 141},
            { 35, 137, 141}, { 34, 137, 141}, { 34, 138, 141}, { 34, 139, 141},
            { 33, 140, 141}, { 33, 141, 140}, { 33, 142, 140}, { 32, 143, 140},
            { 32, 144, 140}, { 32, 145, 140}, { 31, 146, 140}, { 31, 147, 139},
            { 31, 148, 139}, { 31, 149, 139}, { 31, 150, 139}, { 30, 151, 138},
            { 30, 152, 138}, { 30, 153, 138}, { 30, 153, 138}, { 30, 154, 137},
            { 30, 155, 137}, { 30, 156, 137}, { 30, 157, 136}, { 30, 158, 136},
            { 30, 159, 136}, { 30, 160, 135}, { 31, 161, 135}, { 31, 162, 134},
            { 31, 163, 134}, { 32, 164, 133}, { 32, 165, 133}, { 33, 166, 133},
            { 33, 167, 132}, { 34, 167, 132}, { 35, 168, 131}, { 35, 169, 130},
            { 36, 170, 130}, { 37, 171, 129}, { 38, 172, 129}, { 39, 173, 128},
            { 40, 174, 127}, { 41, 175, 127}, { 42, 176, 126}, { 43, 177, 125},
            { 44, 177, 125}, { 46, 178, 124}, { 47, 179, 123}, { 48, 180, 122},
            { 50, 181, 122}, { 51, 182, 121}, { 53, 183, 120}, { 54, 184, 119},
            { 56, 185, 118}, { 57, 185, 118}, { 59, 186, 117}, { 61, 187, 116},
            { 62, 188, 115}, { 64, 189, 114}, { 66, 190, 113}, { 68, 190, 112},
            { 69, 191, 111}, { 71, 192, 110}, { 73, 193, 109}, { 75, 194, 108},
            { 77, 194, 107}, { 79, 195, 105}, { 81, 196, 104}, { 83, 197, 103},
            { 85, 198, 102}, { 87, 198, 101}, { 89, 199, 100}, { 91, 200,  98},
            { 94, 201,  97}, { 96, 201,  96}, { 98, 202,  95}, {100, 203,  93},
            {103, 204,  92}, {105, 204,  91}, {107, 205,  89}, {109, 206,  88},
            {112, 206,  86}, {114, 207,  85}, {116, 208,  84}, {119, 208,  82},
            {121, 209,  81}, {124, 210,  79}, {126, 210,  78}, {129, 211,  76},
            {131, 211,  75}, {134, 212,  73}, {136, 213,  71}, {139, 213,  70},
            {141, 214,  68}, {144, 214,  67}, {146, 215,  65}, {149, 215,  63},
            {151, 216,  62}, {154, 216,  60}, {157, 217,  58}, {159, 217,  56},
            {162, 218,  55}, {165, 218,  53}, {167, 219,  51}, {170, 219,  50},
            {173, 220,  48}, {175, 220,  46}, {178, 221,  44}, {181, 221,  43},
            {183, 221,  41}, {186, 222,  39}, {189, 222,  38}, {191, 223,  36},
            {194, 223,  34}, {197, 223,  33}, {199, 224,  31}, {202, 224,  30},
            {205, 224,  29}, {207, 225,  28}, {210, 225,  27}, {212, 225,  26},
            {215, 226,  25}, {218, 226,  24}, {220, 226,  24}, {223, 227,  24},
            {225, 227,  24}, {228, 227,  24}, {231, 228,  25}, {233, 228,  25},
            {236, 228,  26}, {238, 229,  27}, {241, 229,  28}, {243, 229,  30},
            {246, 230,  31}, {248, 230,  33}, {250, 230,  34}, {253, 231,  36}
        });

        #endregion

        /// <summary>
        /// Convenient dictionary for mapping palette names onto palette byte arrays
        /// </summary>
        public static readonly Dictionary<string, Lazy<byte[,]>>
            ByName = new Dictionary<string, Lazy<byte[,]>>
        {
            { "afmhot", Afmhot },
            { "gist_earth", GistEarth },
            { "inferno", Inferno },
            { "terrain", Terrain },
            { "viridis", Viridis }
        };

        /// <summary>
        /// Enumerate all available palettes / colormaps
        /// </summary>
        public static IEnumerable<string> Names
        {
            get { return ByName.Keys; }
        }
    }
#endif

}