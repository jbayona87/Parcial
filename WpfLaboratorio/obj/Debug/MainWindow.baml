   M S B A M L   `   `   `  ����I  EWpfLaboratorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfLaboratorioWpfLaboratorio  5   	       WpfLaboratorio.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfLaboratorio     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��900��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��380 �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ MuestrasDataGrid��5      $��1��6Z   $
��Left=�6j   $��	10,10,0,0q�6�   $	��Top=�6�   $	��309��6�   $	��492��6�   ��6-   �� *MuestrasResgistradas+6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��	23,40,0,0q�6B   $
��Wrap=�6U   $��Id��6i   $	��Top=�6s   �� 5   
   -   5         ��Name$ txtId��5      $��0��6@   $
��Left=�6P   $��20��6k   $��
190,40,0,0q�6w    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��168��6�   ��6!   �� *muestraDto.Id+6�   �� 5   
   -   5        $ 
textBlock1��5      $
��Left=�6(   $��	23,70,0,0q�6C   $
��Wrap=�6V   $��Persona Muestrada��6j   $	��Top=�6�   �� 5   
   -   5        $ txtPersonaMuestrada��5      $��0��6]   $
��Left=�6m   $��20��6�   $��
190,70,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��168��6�   ��6/   �� *muestraDto.Persona_Muestrada+6�   �� 5   
   -   5        $ 
textBlock2��5      $
��Left=�6(   $��
23,100,0,0q�6C   $
��Wrap=�6W   $��	Fec. Toma��6k   $	��Top=�6|   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	dpFecToma��5      $��0��6W   $
��Left=�6g   $��190,100,0,0q�6�   $	��Top=�6�   $	��168��6�      SelectedDate 6(   �� *muestraDto.Fecha_Toma+6�   �� 5   
   -   5        $ 
textBlock3��5      $
��Left=�6(   $��
23,130,0,0q�6C   $
��Wrap=�6W   $��Persona Toma Muestra��6k   $	��Top=�6�   �� 5   
   -	   5        $ txtPersonaTomaMuestra��5      $��0��6b   $
��Left=�6r   $��20��6�   $��190,130,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��168��6�   ��61   �� *!muestraDto.Persona_Toma_Muestra+6�   �� 5   
   -
   5         ��Name$ btnRegistrar��5      $��	Registrar��6'   $��0��6;   $
��Left=�6K   $��
29,200,0,0q�6f   $��0��6z   $	��Top=�6�   $	��168��6�   $��43��6�   6�   �� 5   
   -   5        $ btnActualizar��5      $��
Actualizar��6(   $��0��6=   $
��Left=�6M   $��200,200,0,0q�6h   $��0��6}   $	��Top=�6�   $	��168��6�   $��43��6�   6�   �� 5   
   -   5        $ btnEliminar��5      $��Eliminar��6&   $��0��69   $
��Left=�6I   $��110,250,0,0q�6d   $��0��6y   $	��Top=�6�   $	��168��6�   $��43��6�   6�   5!      5"      