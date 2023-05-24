Public MustInherit Class Operacion


    Public Shared Property numero1 As Double = -1
    Public Shared Property numero2 As Double = -1
    Public Property Numero_1 As Double
        Get
            Return numero1
        End Get
        Set(ByVal value As Double)
            numero1 = value


        End Set
    End Property

    Public Property Numero_2 As Double
        Get
            Return numero2
        End Get
        Set(ByVal value As Double)
            numero2 = value
        End Set
    End Property

    Public MustOverride Function Calcular() As Double
End Class


