using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkSuite.Framework;
using fft;
using heapsort;
using raytracer;
using sparsematmult;

namespace CSGrande.Benchmark
{
	[BenchFixture]
    public class CsGrandeBenchmark
	{
		[Bench]
		public void ArithBench()
		{
			var benchmark = BenchmarkSuite.Framework.Benchmark.StartNew();
			JGFArithBench.Main();

			benchmark.Stop();
		}

		[Bench]
		public void AssignBench()
		{
			var benchmark = BenchmarkSuite.Framework.Benchmark.StartNew();
			JGFAssignBench.Main();

			benchmark.Stop();
		}

		[Bench]
		public void CastBench()
		{
			var benchmark = BenchmarkSuite.Framework.Benchmark.StartNew();
			JGFCastBench.Main();

			benchmark.Stop();
		}

		[Bench]
		public void CreateBench()
		{
			var benchmark = BenchmarkSuite.Framework.Benchmark.StartNew();
			JGFCreateBench.Main();

			benchmark.Stop();
		}

		[Bench]
		public void FftBench()
		{
			var benchmark = BenchmarkSuite.Framework.Benchmark.StartNew();
			JGFFFTBench.Main();

			benchmark.Stop();
		}

		[Bench]
		public void HeapSortBench()
		{
			var benchmark = BenchmarkSuite.Framework.Benchmark.StartNew();
			JGFHeapSortBench.Main();

			benchmark.Stop();
		}

		[Bench]
		public void LoopBench()
		{
			var benchmark = BenchmarkSuite.Framework.Benchmark.StartNew();
			JGFLoopBench.Main();

			benchmark.Stop();
		}

		[Bench]
		public void RayTracerBench()
		{
			var benchmark = BenchmarkSuite.Framework.Benchmark.StartNew();
			RayTracer.Main();

			benchmark.Stop();
		}

		[Bench]
		public void SparseMatmultBench()
		{
			var benchmark = BenchmarkSuite.Framework.Benchmark.StartNew();
			JGFSparseMatmultBench.Main();

			benchmark.Stop();
		}
    }
}
