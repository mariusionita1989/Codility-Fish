using System.Runtime.CompilerServices;

namespace Codility_Fish
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A, int[] B)
        {
            int N = A.Length;
            int M = B.Length;
            Stack<int> downstreamFish = new Stack<int>();
            int aliveFishCount = 0;

            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE &&
                M >= RANGE_LOWEST_VALUE && M <= RANGE_HIGHEST_VALUE) 
            {
                for (int i = 0; i < N; i++)
                {
                    if (B[i] == 0)
                    { // Fish moving upstream
                        while (downstreamFish.Count > 0)
                        {
                            int downstreamFishSize = downstreamFish.Pop();
                            if (downstreamFishSize > A[i])
                            {
                                downstreamFish.Push(downstreamFishSize); // The downstream fish survives
                                break; // The upstream fish is eaten
                            }
                        }
                        if (downstreamFish.Count == 0)
                        {
                            aliveFishCount++; // The upstream fish survives
                        }
                    }
                    else
                    {
                        // Fish moving downstream
                        downstreamFish.Push(A[i]);
                    }
                }

                return aliveFishCount + downstreamFish.Count;
            }

            return 0;
        }
    }
}
