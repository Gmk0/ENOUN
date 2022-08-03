Public Class GetActeNaissance

    Dim idActe As Integer
    Dim nomEnfant, lieuNenfant, sexe, nomPere, lieuP, NationaliteP, nomMere, lieuM, nationaliteM, adresseP As String
    Dim dateNaissE, dateNaissP, dateNaissM As String
    Dim prov, ville, territoire, chefferie, bureauP, bureauS, officier, comparu, qualite As String


    Public Property getlieuNenfant
        Get
            Return lieuNenfant
        End Get
        Set(ByVal value)
            lieuNenfant = value
        End Set
    End Property
    Public Property getActeNAISS
        Get
            Return idActe
        End Get
        Set(ByVal value)
            idActe = value
        End Set
    End Property
    Public Property Getsexe
        Get
            Return sexe
        End Get
        Set(ByVal value)
            sexe = value
        End Set
    End Property
    Public Property GetnomPere
        Get
            Return nomPere
        End Get
        Set(ByVal value)
            nomPere = value
        End Set
    End Property
    Public Property getlieuNaissP
        Get
            Return lieuP
        End Get
        Set(ByVal value)
            lieuP = value
        End Set
    End Property
    Public Property getNationaliteP
        Get
            Return NationaliteP
        End Get
        Set(ByVal value)
            NationaliteP = value
        End Set
    End Property
    Public Property getnomMere
        Get
            Return nomMere
        End Get
        Set(ByVal value)
            nomMere = value
        End Set
    End Property
    Public Property getlieuM
        Get
            Return lieuM
        End Get
        Set(ByVal value)
            lieuM = value
        End Set
    End Property
    Public Property getnationaliteM
        Get
            Return nationaliteM
        End Get
        Set(ByVal value)
            nationaliteM = value
        End Set
    End Property
    Public Property GetadresseP
        Get
            Return adresseP
        End Get
        Set(ByVal value)
            adresseP = value
        End Set
    End Property
    Public Property getdateNaissE
        Get
            Return dateNaissE
        End Get
        Set(ByVal value)
            dateNaissE = value
        End Set
    End Property
    Public Property getdateNaissP
        Get
            Return dateNaissP
        End Get
        Set(ByVal value)
            dateNaissP = value
        End Set
    End Property
    Public Property getNomE
        Get
            Return nomEnfant
        End Get
        Set(ByVal value)
            nomEnfant = value
        End Set
    End Property
    Public Property getdateNaissM
        Get
            Return dateNaissM
        End Get
        Set(ByVal value)
            dateNaissM = value
        End Set
    End Property

    Public Property Getprov
        Get
            Return prov
        End Get
        Set(ByVal value)
            prov = value
        End Set
    End Property
    Public Property getville
        Get
            Return ville
        End Get
        Set(ByVal value)
            ville = value
        End Set
    End Property
    Public Property getterritoire
        Get
            Return territoire
        End Get
        Set(ByVal value)
            territoire = value
        End Set
    End Property
    Public Property getchefferie
        Get
            Return chefferie
        End Get
        Set(ByVal value)
            chefferie = value
        End Set
    End Property
    Public Property getBureauP
        Get
            Return bureauP
        End Get
        Set(ByVal value)
            bureauP = value
        End Set
    End Property
    Public Property getBureauS
        Get
            Return bureauS
        End Get
        Set(ByVal value)
            bureauS = value
        End Set
    End Property
    Public Property getOfficier
        Get
            Return officier
        End Get
        Set(ByVal value)
            officier = value
        End Set
    End Property
    Public Property getComparu
        Get
            Return comparu
        End Get
        Set(ByVal value)
            comparu = value
        End Set
    End Property
    Public Property getqualite
        Get
            Return qualite
        End Get
        Set(ByVal value)
            qualite = value
        End Set
    End Property


    Public Sub New()

    End Sub
    Public Sub New(ByVal idActe As Integer, ByVal nomEnfant As String, ByVal lieuNenfant As String, ByVal sexe As String, ByVal nomPere As String, ByVal lieuP As String, ByVal NationaliteP As String, ByVal nomMere As String, ByVal lieuM As String, ByVal nationaliteM As String, ByVal adresseP As String, ByVal dateNaissE As String, ByVal dateNaissP As String, ByVal dateNaissM As String, ByVal prov As String, ByVal ville As String, ByVal territoire As String, ByVal chefferie As String, ByVal bureauP As String, ByVal bureauS As String, ByVal officier As String, ByVal comparu As String, ByVal qualite As String)
        getActeNAISS = idActe
        getNomE = nomEnfant
        getlieuNenfant = lieuNenfant
        Getsexe = sexe
        GetnomPere = nomPere
        getnomMere = nomMere
        getlieuNaissP = lieuP
        getNationaliteP = NationaliteP
        getnationaliteM = nationaliteM
        getlieuM = lieuM
        GetadresseP = adresseP
        getdateNaissE = dateNaissE
        getdateNaissM = dateNaissM
        getdateNaissP = dateNaissP
        Getprov = prov
        getville = ville
        getterritoire = territoire
        getchefferie = chefferie
        getBureauP = bureauP
        getBureauS = bureauS
        getOfficier = officier
        getComparu = comparu
        getqualite = qualite

    End Sub

End Class
