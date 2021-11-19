<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="resultOperation PREND_LA_VALEUR firstNumber - secondNumber" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2defaut="" F2para="" F2lignes="" F2etat="inactif"/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalAffichages="1000" maxBoucle="500000" nbDecimales="8" epaisseurPoint="2" totalBoucles="5000000" arrondiAuto="vrai" epaisseurLigne="2"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#firstNumber" algoitem="firstNumber EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#secondNumber" algoitem="secondNumber EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#calculateAnOtherNumber" algoitem="calculateAnOtherNumber EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#resultOperation" algoitem="resultOperation EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#signOperation" algoitem="signOperation EST_DU_TYPE CHAINE"/>
        <item code="1#CHAINE#whichOperation" algoitem="whichOperation EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Welcome to the calculate!#1" algoitem="AFFICHER &quot;Welcome to the calculate!&quot;"/>
        <item code="5#calculateAnOtherNumber#1#pasliste" algoitem="calculateAnOtherNumber PREND_LA_VALEUR 1"/>
        <item code="15#calculateAnOtherNumber" algoitem="TANT_QUE (calculateAnOtherNumber) FAIRE">
            <item code="16#debuttantque" algoitem="DEBUT_TANT_QUE"/>
            <item code="4#Enter the first number for the operation#1" algoitem="AFFICHER &quot;Enter the first number for the operation&quot;"/>
            <item code="2#firstNumber#pasliste" algoitem="LIRE firstNumber"/>
            <item code="4#Enter the second number#1" algoitem="AFFICHER &quot;Enter the second number&quot;"/>
            <item code="2#secondNumber#pasliste" algoitem="LIRE secondNumber"/>
            <item code="4#What operation do you want to do ?#1" algoitem="AFFICHER &quot;What operation do you want to do ?&quot;"/>
            <item code="4# + : addition ; - : substraction ; * : multiplication ; / : division#1" algoitem="AFFICHER &quot; + : addition ; - : substraction ; * : multiplication ; / : division&quot;"/>
            <item code="2#whichOperation#pasliste" algoitem="LIRE whichOperation"/>
            <item code="6#whichOperation == &quot;+&quot;" algoitem="SI (whichOperation == &quot;+&quot;) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#resultOperation#firstNumber + secondNumber#pasliste" algoitem="resultOperation PREND_LA_VALEUR firstNumber + secondNumber"/>
                <item code="5#signOperation#&quot;+&quot;#pasliste" algoitem="signOperation PREND_LA_VALEUR &quot;+&quot;"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="6#whichOperation == &quot;-&quot;" algoitem="SI (whichOperation == &quot;-&quot;) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#resultOperation#firstNumber - secondNumber#pasliste" algoitem="resultOperation PREND_LA_VALEUR firstNumber - secondNumber"/>
                <item code="5#signOperation#&quot;-&quot;#pasliste" algoitem="signOperation PREND_LA_VALEUR &quot;-&quot;"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="6#whichOperation == &quot;*&quot;" algoitem="SI (whichOperation == &quot;*&quot;) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#resultOperation#firstNumber * secondNumber#pasliste" algoitem="resultOperation PREND_LA_VALEUR firstNumber * secondNumber"/>
                <item code="5#signOperation#&quot;*&quot;#pasliste" algoitem="signOperation PREND_LA_VALEUR &quot;*&quot;"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="6#whichOperation == &quot;/&quot;" algoitem="SI (whichOperation == &quot;/&quot;) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#resultOperation#firstNumber / secondNumber#pasliste" algoitem="resultOperation PREND_LA_VALEUR firstNumber / secondNumber"/>
                <item code="5#signOperation#&quot;/&quot;#pasliste" algoitem="signOperation PREND_LA_VALEUR &quot;/&quot;"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="3#firstNumber#0#pasliste" algoitem="AFFICHER firstNumber"/>
            <item code="3#signOperation#0#pasliste" algoitem="AFFICHER signOperation"/>
            <item code="3#secondNumber#0#pasliste" algoitem="AFFICHER secondNumber"/>
            <item code="4#=#0" algoitem="AFFICHER &quot;=&quot;"/>
            <item code="3#resultOperation#1#pasliste" algoitem="AFFICHER resultOperation"/>
            <item code="4#Do you want make an other calcul ? (1 = yes; 0 = exit)#1" algoitem="AFFICHER &quot;Do you want make an other calcul ? (1 = yes; 0 = exit)&quot;"/>
            <item code="2#calculateAnOtherNumber#pasliste" algoitem="LIRE calculateAnOtherNumber"/>
            <item code="17#fintantque" algoitem="FIN_TANT_QUE"/>
        </item>
        <item code="4#Bye bye :) #1" algoitem="AFFICHER &quot;Bye bye :) &quot;"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
