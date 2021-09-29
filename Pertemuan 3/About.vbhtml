@Code
    Layout = "~/_SiteLayout.vbhtml"
    PageData("Title") = "About"

    'variabel global
    Dim Text1 As String = "ini Contoh Text 1"
    Dim Text2 As String = "ini Contoh Text 2"
    Dim Text3 As String = "ini Contoh Text 3"

    Dim angka1 As Integer = 7
    Dim angka2 As Double = 3.14
    Dim Kondisi As Boolean = True

    Dim hasil As Double
    hasil = angka1 + angka2

End Code

<hgroup class="title">
    <h1>@PageData("Title").</h1>
    <h2>Your app description page.</h2>
</hgroup>

<article>
    <>
    <!--Print Variable Global-->
    ini text 1 = @Text1 <br>

    <i> Ini Text 2 = @Text2</i><br>
    <b> Ini Text 3 = @Text3</b><br>
    <h5> Ini Integer = @angka1</h5>
    <h4> Ini Double = @angka2</h4>
    <h3> Ini Boolean = @Kondisi</h3>
    <br>

    Ini dalam bentuk list
    <ul>
        <li>@Text1</li>
        <li>@Text2</li>
        <li>@Text3</li>
        <li>@angka1</li>
        <li>@angka2</li>
        <li>@Kondisi</li>
    </ul>

    <!--Perhitungan aritmatika-->

    ini @angka1 + @angka2 = @hasil<br>
    ini @angka1 - @angka2 = @(angka1 - angka2)<br>
  
    <!--code dalam print vb-->

    @code
        Dim hasil2 As Double
        hasil2 = angka1 * angka2
    End Code
    ini @angka1 * @angka2 =@hasil2 <br>

    <!--Code vb dalam html & Print dalam vb-->
    @code
        Dim hasil3 As Double
        hasil3 = angka1 / angka2
        @:ini @angka1
        @: / @angka2
        @: = @hasil3
        @:<br>
    End Code

    <!--Code dalam HTML Print dalam Vb-->
    @code
        Dim hasil4 As Double
        hasil4 = angka1 Mod angka2
        @<text> ini </text>@angka1
        @<text> % </text>@angka2
        @<text> = </text>@hasil4
        @<text> <br> </text>


    End Code

    <!--HTML Tag-->
    @code
        Dim divHTML As String = "<b> ini tuliasan bold dari variable</b>"
    End Code
    <div>@divHTML</div>
    <div>@Html.Raw(divHTML)</div>

    <!--Style-->
    @code
        Dim divStyle As String = "background-color: yellow;"
    End Code
    <div style="@divStyle"> Ini text dengan Style </div>
</article>

<aside>
    <h3>Aside Title</h3>
    <p>
        Use this area to provide additional information.
    </p>
    <ul>
        <li><a href="~/">Home</a></li>
        <li><a href="~/About">About</a></li>
        <li><a href="~/Contact">Contact</a></li>
    </ul>
</aside>