using Codility_Fish;

namespace Codility_FishTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestExampleCase()
        {
            int[] A = new int[] { 4, 3, 2, 1, 5 };
            int[] B = new int[] { 0, 1, 0, 0, 0 };
            int expected = 2;
            int result = new Solution().solution(A, B);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAllFishMovingUpstream()
        {
            int[] A = new int[] { 4, 3, 2, 1, 5 };
            int[] B = new int[] { 0, 0, 0, 0, 0 };
            int expected = 5;
            int result = new Solution().solution(A, B);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAllFishMovingDownstream()
        {
            int[] A = new int[] { 4, 3, 2, 1, 5 };
            int[] B = new int[] { 1, 1, 1, 1, 1 };
            int expected = 5;
            int result = new Solution().solution(A, B);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestFishMeetingOnlyOnce()
        {
            int[] A = new int[] { 4, 3, 2, 1, 5 };
            int[] B = new int[] { 0, 0, 1, 1, 1 };
            int expected = 5;
            int result = new Solution().solution(A, B);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestNoFishMeeting()
        {
            int[] A = new int[] { 4, 3, 2, 1, 5 };
            int[] B = new int[] { 1, 0, 1, 0, 1 };
            int expected = 3;
            int result = new Solution().solution(A, B);
            Assert.Equal(expected, result);
        }
    }
}