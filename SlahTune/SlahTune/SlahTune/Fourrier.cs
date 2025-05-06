using System;
using System.Linq;
using System.Numerics;
using FFTW.NET;
using NAudio.Wave;

namespace SlahTune
{
    public class Fourrier
    {
        PinnedArray<Complex> Output { get; set; }
        public Complex[] AudioToComplex(string path, int count = 1024, int position = 0)
        {
            var reader = new AudioFileReader(path);
            var waveOut = new WaveOut();
            waveOut.Init(reader);
            var provider = reader.ToSampleProvider();
            reader.Position = position;

            float[] samples = new float[count];
            provider.Read(samples, 0, count);

            Complex[] signal = new Complex[count];

            for (int i = 0; i < count; i++)
            {
                signal[i] = new Complex(samples[i], 0);
            }

            waveOut.Dispose();
            reader.Dispose();

            return signal;
        }
        
        public Complex[] AudioToComplexWithTime(string path, TimeSpan start, TimeSpan duration)
        {
            var reader = new AudioFileReader(path);
            var waveOut = new WaveOut();
            waveOut.Init(reader);
            reader.Position = 0;
            var provider = reader.ToSampleProvider()
                .Skip(start).Take(duration);

            int count = 2 * 88100;
            float[] samples = new float[count];
            provider.Read(samples, 0, count);

            Complex[] signal = new Complex[count];

            for (int i = 0; i < count; i++)
            {
                signal[i] = new Complex(samples[i], 0);
            }

            waveOut.Dispose();
            reader.Dispose();

            return signal;
        }

        public IPinnedArray<Complex> ComputeFFT(Complex[] input)
        {
            Complex[] output = new Complex[input.Length];

            using (var pinIn = new PinnedArray<Complex>(input))
                using (var pinOut = new PinnedArray<Complex>(output))
            {
                DFT.FFT(pinIn, pinOut);
                Output = pinOut;
            }

            return Output;
        }

        public Complex[] ComputeFFTAsArray(Complex[] input)
        {
            Complex[] output = new Complex[input.Length];

            using (var pinIn = new PinnedArray<Complex>(input))
            using (var pinOut = new PinnedArray<Complex>(output))
            {
                DFT.FFT(pinIn, pinOut);
                Output = pinOut;
            }

            return Output.Buffer as Complex[];
        }
    }
}