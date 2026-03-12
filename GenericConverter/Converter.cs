using System;
using System.Collections.Generic;
using System.Text;


class Converter<TInput, TOutput>
{
    public Func<TInput, TOutput> converter;

    public Converter(Func<TInput, TOutput> converter)
    {
        this.converter = converter;
    }


    public TOutput Convert(TInput input)
    {
        return converter(input); 
    }


    public TOutput[] ConvertAll(TInput[] inputs)
    {
        TOutput[] outputs = new TOutput[inputs.Length];

        int count = 0;
        foreach (TInput input in inputs)
        {
            outputs[count++] = converter(input);
        }



        return outputs;
    }
}