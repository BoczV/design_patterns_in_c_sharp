using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter;

public class Expression
{
    private readonly double _leftHandSide;
    private readonly double _rightHandSide;
    
    private readonly OperationType _operationTypeoperationType;

    public Expression(double leftHandSide, double rightHandSide, OperationType operationTypeoperationType)
    {
        _leftHandSide = leftHandSide;
        _rightHandSide = rightHandSide;
        _operationTypeoperationType = operationTypeoperationType;
    }

    public double Process()
    {
        switch (_operationTypeoperationType)
        {
            case OperationType.Addition:
                return _leftHandSide + _rightHandSide;
            case OperationType.Subtraction:
                return _leftHandSide - _rightHandSide;
            case OperationType.Multiplication:
                return _leftHandSide * _rightHandSide;
            case OperationType.Division:
                return _leftHandSide / _rightHandSide;
            default: throw new InvalidOperationException();
        }
    }
}
