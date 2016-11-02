<table class="table table-bordered">
  <tr>
    <th></th>
    <th colspan="2">Quicksort</th>
    <th colspan="2">Quicksort3</th>
    <th colspan="2">Mergesort</th>
    <th colspan="2">Bubblesort</th>
  </tr>
  <tr>
    <th></th>
    <td>gesorteerd</td>
    <td>geshuffled</td>
    <td>gesorteerd</td>
    <td>geshuffled</td>
    <td>gesorteerd</td>
    <td>geshuffled</td>
    <td>gesorteerd</td>
    <td>geshuffled</td>
  </tr>
  <tr>
    <th>Aantal vergelijkingen</th>
    <td>50143723</td>
    <td>148723</td>
    <td>16832111</td>
    <td>147868</td>
    <td>133616</td>
    <td>65348</td>
    <td>99990000</td>
    <td>99990000</td>
  </tr>
  <tr>
    <th>Aantal swaps</th>
    <td>101195</td>
    <td>81197</td>
    <td>101195</td>
    <td>101195</td>
    <td>133616</td>
    <td>133616</td>
    <td>0</td>
    <td>25094131</td>
  </tr>
  <tr>
    <th>Uitvoertijd</th>
    <td>0.3356</td>
    <td>0.0018</td>
    <td>0.1122</td>
    <td>0.0015</td>
    <td>0.0011</td>
    <td>0.002</td>
    <td>0.6622</td>
    <td>0.9701</td>
  </tr>
</table>

Quicksort unsorted duurd ongeveer even lang als Quicksort3 unsorted. Eventuele verschillen zijn slechts te wijten aan "geluk" (de quicksort 3 median kan beter uitkomen, maar ook slechter).

Bij Quicksort3 zie je wel dat de sorted meer dan 3x zo snel wordt uitgevoerd als de normale quicksort.

Dat komt natuurlijk omdat de median bij quicksort3 beter is bepaald, wat bij het sorten van een sorted list beter is. Wanneer bij quicksort bij een sorted lijst telkens de linker index na de vorige pivotposition als index word gebruikt, wordt de array vak voor vak opgeschroven, wat erg langzaam is.
