I have create a Generic javascript file(having dependecy on Jquery) that can create any html table responsive for mobile screen without using any extra efforts.
just add tableResponsive.js after Jquery script or end of all script tags. 
![image](https://github.com/orbitrover/ResponsiveTableGrid/assets/8413437/38c2ea74-367f-4d27-b8c8-b40f620868f3)


and its working, No need to extra css or any other library.
No Need to change in Static Table Grid just add ID attribute in any div before the table [id="no-more-tables"]
<div class=container id="no-more-tables">
<table class=table>
<thead>
<tr>
<th>
Item Number
</th>
<th>
Pizza Name
</th>
<th>
Item Size
</th>
<th>
Pizza Description
</th>
<th>Action</th>
</tr>
</thead>
<tbody>
<tr>
<td>
123001
</td>
<td>
Onion Pizza
</td>
<td>
Large
</td>
<td>
Onion with Mozerlla Cheez
</td>
<td>
<a href=/PizzaStore/Edit>Edit</a> |
<a href=/PizzaStore/Details>Details</a> |
<a href=/PizzaStore/Delete>Delete</a>
</td>
</tr>
<tr>
<td>
123002
</td>
<td>
Onion Pizza
</td>
<td>
Medium
</td>
<td>
Onion with Mozerlla Cheez
</td>
<td>
<a href=/PizzaStore/Edit>Edit</a> |
<a href=/PizzaStore/Details>Details</a> |
<a href=/PizzaStore/Delete>Delete</a>
</td>
</tr>
<tr>
<td>
123003
</td>
<td>
Onion Pizza
</td>
<td>
Small
</td>
<td>
Onion with Mozerlla Cheez
</td>
<td>
<a href=/PizzaStore/Edit>Edit</a> |
<a href=/PizzaStore/Details>Details</a> |
<a href=/PizzaStore/Delete>Delete</a>
</td>
</tr>
<tr>
<td>
123004
</td>
<td>
Capiscum Pizza
</td>
<td>
Large
</td>
<td>
Capiscum, Onion with Mozerlla Cheez
</td>
<td>
<a href=/PizzaStore/Edit>Edit</a> |
<a href=/PizzaStore/Details>Details</a> |
<a href=/PizzaStore/Delete>Delete</a>
</td>
</tr>
<tr>
<td>
123005
</td>
<td>
Capiscum Pizza
</td>
<td>
Medium
</td>
<td>
Capiscum, Onion with Mozerlla Cheez
</td>
<td>
<a href=/PizzaStore/Edit>Edit</a> |
<a href=/PizzaStore/Details>Details</a> |
<a href=/PizzaStore/Delete>Delete</a>
</td>
</tr>
<tr>
<td>
123006
</td>
<td>
Capiscum Pizza
</td>
<td>
Small
</td>
<td>
Capiscum, Onion with Mozerlla Cheez
</td>
<td>
<a href=/PizzaStore/Edit>Edit</a> |
<a href=/PizzaStore/Details>Details</a> |
<a href=/PizzaStore/Delete>Delete</a>
</td>
</tr>
</tbody>
</table>
</div>
Also No Need to change in Dynamic Table Grid just add ID attribute in any div before the table [id="no-more-tables"]

![image](https://github.com/orbitrover/ResponsiveTableGrid/assets/8413437/c0f002c1-20a8-4ad7-b0aa-0aac391d4915)

Before

![image](https://github.com/orbitrover/ResponsiveTableGrid/assets/8413437/7adb0ea7-260f-4ff9-8b0b-b937628d9f53)


After

![image](https://github.com/orbitrover/ResponsiveTableGrid/assets/8413437/4632fee6-d8c7-4a02-aa68-87deaa3c57c7)

