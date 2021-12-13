<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot;.&quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2para="" F2etat="inactif" F2defaut="" F2lignes=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurLigne="2" totalAffichages="1000" arrondiAuto="vrai" maxBoucle="500000" totalBoucles="5000000" nbDecimales="8" epaisseurPoint="2"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="amIAngry EST_DU_TYPE NOMBRE" code="1#NOMBRE#amIAngry"/>
        <item algoitem="isDishAvailable EST_DU_TYPE NOMBRE" code="1#NOMBRE#isDishAvailable"/>
        <item algoitem="doIWantTheDish EST_DU_TYPE NOMBRE" code="1#NOMBRE#doIWantTheDish"/>
        <item algoitem="plateIsFull EST_DU_TYPE NOMBRE" code="1#NOMBRE#plateIsFull"/>
        <item algoitem="dishName EST_DU_TYPE CHAINE" code="1#CHAINE#dishName"/>
        <item algoitem="howManyDish EST_DU_TYPE NOMBRE" code="1#NOMBRE#howManyDish"/>
        <item algoitem="allDishTaken EST_DU_TYPE CHAINE" code="1#CHAINE#allDishTaken"/>
        <item algoitem="isAllDishHasBeenShow EST_DU_TYPE NOMBRE" code="1#NOMBRE#isAllDishHasBeenShow"/>
        <item algoitem="doIWantExtraFinishBonus EST_DU_TYPE NOMBRE" code="1#NOMBRE#doIWantExtraFinishBonus"/>
        <item algoitem="isServiceWasGood EST_DU_TYPE NOMBRE" code="1#NOMBRE#isServiceWasGood"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="amIAngry PREND_LA_VALEUR 1" code="5#amIAngry#1#pasliste"/>
        <item algoitem="isAllDishHasBeenShow PREND_LA_VALEUR 0" code="5#isAllDishHasBeenShow#0#pasliste"/>
        <item algoitem="isDishAvailable PREND_LA_VALEUR 1" code="5#isDishAvailable#1#pasliste"/>
        <item algoitem="doIWantTheDish PREND_LA_VALEUR 1" code="5#doIWantTheDish#1#pasliste"/>
        <item algoitem="plateIsFull PREND_LA_VALEUR 0" code="5#plateIsFull#0#pasliste"/>
        <item algoitem="dishName PREND_LA_VALEUR &quot;&quot;" code="5#dishName#&quot;&quot;#pasliste"/>
        <item algoitem="howManyDish PREND_LA_VALEUR 0" code="5#howManyDish#0#pasliste"/>
        <item algoitem="allDishTaken PREND_LA_VALEUR &quot;&quot;" code="5#allDishTaken#&quot;&quot;#pasliste"/>
        <item algoitem="doIWantExtraFinishBonus PREND_LA_VALEUR 0" code="5#doIWantExtraFinishBonus#0#pasliste"/>
        <item algoitem="TANT_QUE (amIAngry) FAIRE" code="15#amIAngry">
            <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
            <item algoitem="TANT_QUE (isAllDishHasBeenShow == 0 ET plateIsFull == 0) FAIRE" code="15#isAllDishHasBeenShow == 0 ET plateIsFull == 0">
                <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
                <item algoitem="SI (plateIsFull == 0) ALORS" code="6#plateIsFull == 0">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="SI (isAllDishHasBeenShow == 0) ALORS" code="6#isAllDishHasBeenShow == 0">
                        <item algoitem="DEBUT_SI" code="7#debutsi"/>
                        <item algoitem="AFFICHER &quot;What is the name of the dish ?&quot;" code="4#What is the name of the dish ?#1"/>
                        <item algoitem="LIRE dishName" code="2#dishName#pasliste"/>
                        <item algoitem="AFFICHER &quot;Is this dish is available ?&quot;" code="4#Is this dish is available ?#1"/>
                        <item algoitem="LIRE isDishAvailable" code="2#isDishAvailable#pasliste"/>
                        <item algoitem="SI (isDishAvailable == 1) ALORS" code="6#isDishAvailable == 1">
                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                            <item algoitem="AFFICHER &quot;Do I want take &quot;" code="4#Do I want take #0"/>
                            <item algoitem="AFFICHER dishName" code="3#dishName#0#pasliste"/>
                            <item algoitem="AFFICHER &quot; ?&quot;" code="4# ?#1"/>
                            <item algoitem="LIRE doIWantTheDish" code="2#doIWantTheDish#pasliste"/>
                            <item algoitem="SI (doIWantTheDish == 1) ALORS" code="6#doIWantTheDish == 1">
                                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                                <item algoitem="AFFICHER &quot;I add &quot;" code="4#I add #0"/>
                                <item algoitem="AFFICHER dishName" code="3#dishName#0#pasliste"/>
                                <item algoitem="AFFICHER &quot; to my plate.&quot;" code="4# to my plate.#1"/>
                                <item algoitem="allDishTaken PREND_LA_VALEUR allDishTaken + &quot; &quot; + dishName" code="5#allDishTaken#allDishTaken + &quot; &quot; + dishName#pasliste"/>
                                <item algoitem="AFFICHER &quot;Actually I have all this dish to my plate :&quot;" code="4#Actually I have all this dish to my plate :#1"/>
                                <item algoitem="AFFICHER allDishTaken" code="3#allDishTaken#1#pasliste"/>
                                <item algoitem="AFFICHER &quot;Is the plate is full ?&quot;" code="4#Is the plate is full ?#1"/>
                                <item algoitem="LIRE plateIsFull" code="2#plateIsFull#pasliste"/>
                                <item algoitem="FIN_SI" code="8#finsi"/>
                            </item>
                            <item algoitem="FIN_SI" code="8#finsi"/>
                        </item>
                        <item algoitem="FIN_SI" code="8#finsi"/>
                    </item>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                </item>
                <item algoitem="howManyDish PREND_LA_VALEUR howManyDish + 1" code="5#howManyDish#howManyDish + 1#pasliste"/>
                <item algoitem="AFFICHER &quot;Has I seen all dishes ?&quot;" code="4#Has I seen all dishes ?#1"/>
                <item algoitem="LIRE isAllDishHasBeenShow" code="2#isAllDishHasBeenShow#pasliste"/>
                <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
            </item>
            <item algoitem="AFFICHER &quot;I will sit down and eat...&quot;" code="4#I will sit down and eat...#1"/>
            <item algoitem="AFFICHER &quot;I eat&quot;" code="4#I eat#0"/>
            <item algoitem="AFFICHER allDishTaken" code="3#allDishTaken#0#pasliste"/>
            <item algoitem="AFFICHER &quot;.&quot;" code="4#.#1"/>
            <item algoitem="AFFICHER &quot;Yum yum this is very good!&quot;" code="4#Yum yum this is very good!#1"/>
            <item algoitem="AFFICHER &quot;Am I still hungry ?&quot;" code="4#Am I still hungry ?#1"/>
            <item algoitem="LIRE amIAngry" code="2#amIAngry#pasliste"/>
            <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
        </item>
        <item algoitem="AFFICHER &quot;I finished my meal&quot;" code="4#I finished my meal#1"/>
        <item algoitem="AFFICHER &quot;Do I want a coffee, a digestive or nothing ?&quot;" code="4#Do I want a coffee, a digestive or nothing ?#1"/>
        <item algoitem="LIRE doIWantExtraFinishBonus" code="2#doIWantExtraFinishBonus#pasliste"/>
        <item algoitem="SI (doIWantExtraFinishBonus == 1) ALORS" code="6#doIWantExtraFinishBonus == 1">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="AFFICHER &quot;I gona take a coffee.&quot;" code="4#I gona take a coffee.#1"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
        </item>
        <item algoitem="SI (doIWantExtraFinishBonus == 2) ALORS" code="6#doIWantExtraFinishBonus == 2">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="AFFICHER &quot;I gona take a digestive.&quot;" code="4#I gona take a digestive.#1"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
        </item>
        <item algoitem="AFFICHER &quot;I ask for the bill and I pay.&quot;" code="4#I ask for the bill and I pay.#1"/>
        <item algoitem="AFFICHER &quot;Is the service was good ?&quot;" code="4#Is the service was good ?#1"/>
        <item algoitem="LIRE isServiceWasGood" code="2#isServiceWasGood#pasliste"/>
        <item algoitem="SI (isServiceWasGood == 1) ALORS" code="6#isServiceWasGood == 1">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="AFFICHER &quot;I give a tip :)&quot;" code="4#I give a tip :)#1"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
        </item>
        <item algoitem="AFFICHER &quot;Bye bye.&quot;" code="4#Bye bye.#1"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
