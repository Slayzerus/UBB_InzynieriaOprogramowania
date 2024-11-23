#NiceToDev Schedules

Opis projektu:
Program zarządzający harmonogramami użytkowników.

Wymagania niefunkcjonalne:
- Czas odpowiedzi systemu poniżej 1 sekundy dla większości operacji.
- Szyfrowanie danych wrażliwych (np. TLS/SSL dla komunikacji, AES dla przechowywania danych).

Wymagania funkcjonalne:
- Dodawanie, edytowanie i usuwanie wydarzeń w harmonogramie.
- Obsługa powtarzających się wydarzeń (np. codziennych, tygodniowych, miesięcznych).
- Tworzenie harmonogramów dla indywidualnych użytkowników lub grup.
- Możliwość synchronizacji harmonogramów (przypisywanie użytkownikówdo wydarzeń)
- Wizualizacja w różnych formatach (dzienny, tygodniowy, miesięczny, roczny).
- Filtry i wyszukiwanie wydarzeń.
- Różne poziomy dostępu (np. właściciel, edytor, widz).
- Możliwość udostępniania harmonogramu innym użytkownikom.

Potencjalne ryzyka:



Diagram aplikacji:
<mxfile host="app.diagrams.net" agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36" version="24.8.9">
  <diagram name="Strona-1" id="KNEcAkoXSS5oCFQM8Vfd">
    <mxGraphModel dx="1173" dy="579" grid="1" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="1" pageScale="1" pageWidth="827" pageHeight="1169" math="0" shadow="0">
      <root>
        <mxCell id="0" />
        <mxCell id="1" parent="0" />
        <mxCell id="ZR9yek1R5PVfgLDflTJq-3" value="" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;" edge="1" parent="1" source="ZR9yek1R5PVfgLDflTJq-1">
          <mxGeometry relative="1" as="geometry">
            <mxPoint x="280" y="360" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-1" value="Użytkownik" style="shape=umlActor;verticalLabelPosition=bottom;verticalAlign=top;html=1;outlineConnect=0;" vertex="1" parent="1">
          <mxGeometry x="170" y="330" width="30" height="60" as="geometry" />
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-5" value="Harmonogram 1" style="rounded=1;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="294" y="330" width="120" height="60" as="geometry" />
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-17" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.75;exitY=1;exitDx=0;exitDy=0;" edge="1" parent="1" source="ZR9yek1R5PVfgLDflTJq-6">
          <mxGeometry relative="1" as="geometry">
            <mxPoint x="387" y="540" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-6" value="" style="swimlane;startSize=0;" vertex="1" parent="1">
          <mxGeometry x="290" y="320" width="130" height="150" as="geometry">
            <mxRectangle x="410" y="320" width="50" height="40" as="alternateBounds" />
          </mxGeometry>
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-7" value="Harmonogram2" style="rounded=1;whiteSpace=wrap;html=1;" vertex="1" parent="ZR9yek1R5PVfgLDflTJq-6">
          <mxGeometry x="4" y="80" width="120" height="60" as="geometry" />
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-16" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.25;exitY=0;exitDx=0;exitDy=0;" edge="1" parent="1" source="ZR9yek1R5PVfgLDflTJq-11">
          <mxGeometry relative="1" as="geometry">
            <mxPoint x="316.33333333333326" y="480" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-11" value="" style="swimlane;startSize=0;" vertex="1" parent="1">
          <mxGeometry x="279" y="550" width="150" height="160" as="geometry" />
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-12" value="Harmonogram B" style="rounded=1;whiteSpace=wrap;html=1;" vertex="1" parent="ZR9yek1R5PVfgLDflTJq-11">
          <mxGeometry x="14" y="90" width="120" height="60" as="geometry" />
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-8" value="Harmonogram A" style="rounded=1;whiteSpace=wrap;html=1;" vertex="1" parent="ZR9yek1R5PVfgLDflTJq-11">
          <mxGeometry x="11" y="20" width="120" height="60" as="geometry" />
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-15" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.5;exitY=0.5;exitDx=0;exitDy=0;exitPerimeter=0;" edge="1" parent="1" source="ZR9yek1R5PVfgLDflTJq-13">
          <mxGeometry relative="1" as="geometry">
            <mxPoint x="270" y="615" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-13" value="Użytkownik" style="shape=umlActor;verticalLabelPosition=bottom;verticalAlign=top;html=1;outlineConnect=0;" vertex="1" parent="1">
          <mxGeometry x="150" y="585" width="30" height="60" as="geometry" />
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-18" value="BD" style="shape=cylinder3;whiteSpace=wrap;html=1;boundedLbl=1;backgroundOutline=1;size=15;" vertex="1" parent="1">
          <mxGeometry x="710" y="370" width="60" height="80" as="geometry" />
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-20" value="Aplikacja" style="swimlane;startSize=0;" vertex="1" parent="1">
          <mxGeometry x="250" y="270" width="270" height="470" as="geometry" />
        </mxCell>
        <mxCell id="ZR9yek1R5PVfgLDflTJq-21" value="" style="shape=flexArrow;endArrow=classic;startArrow=classic;html=1;rounded=0;" edge="1" parent="1">
          <mxGeometry width="100" height="100" relative="1" as="geometry">
            <mxPoint x="540" y="430" as="sourcePoint" />
            <mxPoint x="690" y="430" as="targetPoint" />
          </mxGeometry>
        </mxCell>
      </root>
    </mxGraphModel>
  </diagram>
</mxfile>
