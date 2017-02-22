using System;
public delegate double ActivationFunc(double a);
namespace ymd
{
	//delegate double ActivationFunc(double[] inputs);
	public class Neuron
	{
		double[] weights;
		double bias;
		ActivationFunc actFunc;
		public Neuron(int inputNums, ActivationFunc ActFunc, double[] weights, double bias)
		{
			//Double[] weights = new Double[inputNums];
			this.weights= weights;
			this.actFunc = ActFunc;
			this.bias = bias;
		}

		public double compute(double[] inputs)
		{
			double a = 0;
			for (var i = 0; i < inputs.Length; i++)
			{
				a += inputs[i] * weights[i];
			}
			a += bias;
			return actFunc(a);
		}


	}
}
