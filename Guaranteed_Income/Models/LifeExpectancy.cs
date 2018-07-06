﻿namespace Guaranteed_Income.Models
{
    public static class LifeExpectancy
    {
        private static readonly double [] maleLifeExpectancy = { 0, 80.4710, 79.4713, 78.4718, 77.4726, 76.4734, 75.4744, 74.4756, 73.4768, 72.4782, 71.4796, 70.4812, 69.4829, 68.4847, 67.4866, 66.4887, 65.4909, 64.4933, 63.4958, 62.4985, 61.5013, 60.5044, 59.5076, 58.5110, 57.5147, 56.5186, 55.5228, 54.5273, 53.5321, 52.5373, 51.5427, 50.5486, 49.5549, 48.5617, 47.5689, 46.5768, 45.5854, 44.5946, 43.6046, 42.6154, 41.6269, 40.6393, 39.6526, 38.6668, 37.6821, 36.6987, 35.7168, 34.7367, 33.7586, 32.7830, 31.8103, 30.8409, 29.8748, 28.9119, 27.9524, 26.9963, 26.0436, 25.0947, 24.1497, 23.2091, 22.2732, 21.3424, 20.4174, 19.4987, 18.5870, 17.6831, 16.7877, 15.9019, 15.0266, 14.1625, 13.3107, 12.4718, 11.6470, 10.8377, 10.0452, 9.2711, 8.5176, 7.7864, 7.0800, 6.4008, 5.7514, 5.1345, 4.5531, 4.0100, 3.5067, 3.0456, 2.6273, 2.2521, 1.9208, 1.6336, 1.3885, 1.1841, 1.0166, 0.8827, 0.7779, 0.6975, 0.6375, 0.5937, 0.5624, 0.5408, 0.5261, 0.5163, 0.5100, 0.5061, 0.5037, 0.5022, 0.5013, 0.5008, 0.5005, 0.5003, 0.5002, 0.5001, 0.5001, 0.5000, 0.5000, 0.5000, 0.5000, 0.5000, 0.5000, 0.5000, 0.5000 };
        private static readonly double[] femaleLifeExpectancy = { 0, 82.9032, 81.9035, 80.9040, 79.9046, 78.9054, 77.9062, 76.9071, 75.9081, 74.9092, 73.9103, 72.9116, 71.9129, 70.9142, 69.9157, 68.9172, 67.9189, 66.9206, 65.9225, 64.9245, 63.9266, 62.9288, 61.9311, 60.9335, 59.9361, 58.9387, 57.9415, 56.9445, 55.9475, 54.9508, 53.9542, 52.9578, 51.9616, 50.9657, 49.9701, 48.9748, 47.9799, 46.9852, 45.9910, 44.9971, 44.0036, 43.0105, 42.0179, 41.0258, 40.0343, 39.0434, 38.0531, 37.0636, 36.0750, 35.0874, 34.1011, 33.1163, 32.1331, 31.1517, 30.1724, 29.1956, 28.2215, 27.2508, 26.2838, 25.3210, 24.3630, 23.4101, 22.4631, 21.5225, 20.5889, 19.6631, 18.7458, 17.8377, 16.9396, 16.0525, 15.1772, 14.3148, 13.4663, 12.6328, 11.8154, 11.0154, 10.2338, 9.4720, 8.7321, 8.0154, 7.3237, 6.6587, 6.0219, 5.4153, 4.8404, 4.2991, 3.7938, 3.3271, 2.9010, 2.5163, 2.1741, 1.8737, 1.6136, 1.3916, 1.2055, 1.0518, 0.9265, 0.8257, 0.7461, 0.6838, 0.6356, 0.5986, 0.5706, 0.5498, 0.5344, 0.5234, 0.5156, 0.5102, 0.5066, 0.5041, 0.5026, 0.5016, 0.5009, 0.5006, 0.5003, 0.5002, 0.5001, 0.5001, 0.5000, 0.5000, 0.5000 };
        public static readonly double[] glwbTable = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.045, 0.046, 0.047, 0.048, 0.048, 0.05, 0.051, 0.052, 0.053, 0.054, 0.055, 0.056, 0.057, 0.058, 0.059, 0.06, 0.061, 0.062, 0.063, 0.064, 0.065, 0.066, 0.067, 0.068, 0.069, 0.07, 0.071, 0.072, 0.073, 0.074, 0.075, 0.076, 0.077, 0.078, 0.079, 0.08, 0.081, 0.082, 0.083, 0.084, 0.085, 0.086, 0.087, 0.088, 0.089, 0.09, 0.091, 0.092, 0.093, 0.094 };
        public static double GetLifeExpectancy(int age, Gender gender)
        {
            switch (gender)
            {
                case (Gender.Female):
                    return femaleLifeExpectancy[age];
                case (Gender.Male):
                    return maleLifeExpectancy[age];
                default:
                    return 0;
            }
        }
    }

    public enum Gender{
        Female,
        Male
    }
}