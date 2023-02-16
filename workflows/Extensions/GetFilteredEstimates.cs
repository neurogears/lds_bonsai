using Bonsai;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using Python.Runtime;
using OpenCV.Net;

[Combinator]
[Description("Convert a Python tuple to a 2D point.")]
[WorkflowElementCategory(ElementCategory.Transform)]
public class GetFilteredEstimates
{
    public IObservable<Point2d> Process(IObservable<PyObject> source)
    {
        return source.Select(value =>
        {
            using (Py.GIL())
            {
                dynamic mean = value[0];
                return new Point2d((double)mean[0], (double)mean[1]);
            }
        });
    }
}
