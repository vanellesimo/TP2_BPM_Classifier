using Accord.Statistics.Distributions.Fitting;
using Accord.Statistics.Distributions.Multivariate;
using Accord.Statistics.Models.Markov;
using Accord.Statistics.Models.Markov.Learning;
using Accord.Statistics.Models.Markov.Topology;

namespace MouseGestureRecognition.BLL
{
    public class HiddenMarkovModel
    {
        private HiddenMarkovClassifier<MultivariateNormalDistribution, double[]> hmm;

        private int _states = 5;
        private double _tolerance = 0.01;
        private bool _rejection = false;
        public HiddenMarkovModel()
        {

        }

        public HiddenMarkovModel(int states, double tolerance, bool rejection)
        {
            _states = states;
            _tolerance = tolerance;
            _rejection = rejection;
        }

        public void Train(Database database, int iterations)
        {
            double[][][] inputs = new double[database.Samples.Count][][];
            int[] outputs = new int[database.Samples.Count];

            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = database.Samples[i].Preprocess();
                outputs[i] = database.Samples[i].Output;
            }

            hmm = new HiddenMarkovClassifier<MultivariateNormalDistribution, double[]>(database.Classes.Count,
                new Forward(_states), new MultivariateNormalDistribution(2), database.Classes.ToArray());

            var teacher = new HiddenMarkovClassifierLearning<MultivariateNormalDistribution, double[]>(hmm)
            {
                Learner = i => new BaumWelchLearning<MultivariateNormalDistribution, double[]>(hmm.Models[i])
                {
                    Tolerance = _tolerance,
                    MaxIterations = iterations,

                    FittingOptions = new NormalOptions()
                    {
                        Regularization = 1e-5
                    }
                }
            };

            teacher.Empirical = true;
            teacher.Rejection = _rejection;
            
            teacher.Learn(inputs, outputs);
        }

        public int Decide(Sequence sequence)
        {
            return hmm.Decide(sequence.Preprocess());
        }
    }
}
