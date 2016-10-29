using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCRUMFuncPrime;

namespace SCRUMFuncPrimeTests
{
    [TestClass()]
    public class TennisScoreDisplayBoardTests
    {
        [TestMethod()]
        public void 如果比分为0_0则显示板显示LoveALL()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(0, 0), "Love ALL");
        }

        [TestMethod()]
        public void 如果比分为1_1则显示板显示FifteenALL()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(1, 1), "Fifteen ALL");
        }

        [TestMethod()]
        public void 如果比分为2_2则显示板显示ThirtyALL()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(2, 2), "Thirty ALL");
        }

        [TestMethod()]
        public void 如果比分3_3的平分则显示板显示Deuce()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(3, 3), "Deuce");
        }

        [TestMethod()]
        public void 如果比分4_4的平分则显示板显示Deuce()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(4, 4), "Deuce");
        }

        [TestMethod()]
        public void 如果比分1_0的平分则显示板显示Fifteen_Love()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(1, 0), "Fifteen Love");
        }

        [TestMethod()]
        public void 如果比分2_0的平分则显示板显示Fifteen_Love()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(2, 0), "Thirty Love");
        }

        [TestMethod()]
        public void 如果比分3_0的平分则显示板显示Fifteen_Love()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(3, 0), "Fourty Love");
        }

        [TestMethod()]
        public void 如果比分4_0的平分则显示板显示A_Win()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(4, 0), "A Win");
        }

        [TestMethod()]
        public void 如果比分2_1的平分则显示板显示ThrityFifteen()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(2, 1), "Thirty Fifteen");

        }

        [TestMethod()]
        public void 如果比分3_1的平分则显示板显示FourtyFifteen()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(3, 1), "Fourty Fifteen");
        }

        [TestMethod()]
        public void 如果比分4_1的平分则显示板显示A_Win()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(4, 1), "A Win");
        }

        [TestMethod()]
        public void 如果比分3_2的平分则显示板显示FourtyFifteen()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(3, 2), "Fourty Thirty");
        }

        [TestMethod()]
        public void 如果比分4_2的平分则显示板显示A_Win()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(4, 2), "A Win");
        }

        [TestMethod()]
        public void 如果比分4_3的平分则显示板显示A_Win()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(4, 3), "A Advantage");
        }

        [TestMethod()]
        public void 如果比分5_4的平分则显示板显示A_Win()
        {
            Assert.AreEqual(TennisScoreDisplayBoard.TennisScoreDis(5, 4), "A Advantage");
        }

    }


}



