   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      N JBNACTMFormGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:BNACTMFormGenerator.ModelBNACTMFormGenerator.Model 5      M+clr-namespace:BNACTMFormGenerator.ViewModelBNACTMFormGenerator.ViewModel 5      E'clr-namespace:BNACTMFormGenerator.ViewsBNACTMFormGenerator.Views 5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   PasoGenerico  �� DataType3   -BNACTMFormGenerator.ViewModel.PasoViewModel`1(  "BNACTMFormGenerator.Views.PasoView4 .BNACTMFormGenerator.ViewModel.PasoSQLViewModel+  %BNACTMFormGenerator.Views.PasoSQLView3 -BNACTMFormGenerator.ViewModel.PasoSPViewModel*  $BNACTMFormGenerator.Views.PasoSPView4 .BNACTMFormGenerator.ViewModel.PasoJobViewModel+  %BNACTMFormGenerator.Views.PasoJobView3  -BNACTMFormGenerator.ViewModel.AccionViewModel*	  $BNACTMFormGenerator.Views.AccionView0
  *BNACTMFormGenerator.ViewModel.JobViewModel'  !BNACTMFormGenerator.Views.JobViewA ;BNACTMFormGenerator.ViewModel.TransferenciaArchivoViewModel8  2BNACTMFormGenerator.Views.TransferenciaArchivoView> 8BNACTMFormGenerator.ViewModel.PasoCopiaArchivosViewModel5  /BNACTMFormGenerator.Views.PasoCopiaArchivosViewD >BNACTMFormGenerator.ViewModel.PasoEliminacionArchivosViewModel;  5BNACTMFormGenerator.Views.PasoEliminacionArchivosView3 -BNACTMFormGenerator.ViewModel.PasoSHViewModel*  $BNACTMFormGenerator.Views.PasoSHView: 4BNACTMFormGenerator.ViewModel.FormularioCTMViewModel1  +BNACTMFormGenerator.Views.FormularioCTMView  EnumTipoPaso S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� TypeName  dataFromEnum  EnumTipoOrigen ' #ToolTipWithErrorMessageOnErrorStyle �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value �� RelativeSource �� Path / +ComboBoxToolTipWithErrorMessageOnErrorStyle  TiposSh �� Type  
HorasArray  MinutosArray�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      .sys&clr-namespace:System;assembly=mscorlib  5      1model'clr-namespace:BNACTMFormGenerator.Model  5      2vm+clr-namespace:BNACTMFormGenerator.ViewModel  5      .vw'clr-namespace:BNACTMFormGenerator.Views  5      %�  &	        (�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5      *, +)(�� �     5      *,
 +)(�� ,    5       *, +)(�� ^    5#      *, +)(�� �    5&      *, +)(�� �    5)      *, +)(�� �    5,      *, +)&	 &    &	 �    &	     &	 q    &	 6    &	 �    &	 �    &	 &    �� 5      "    6(   .R�5   
     5      �� 5      "   6   .R�5   
     5      �� 5      "   6   .R�5   
     5      �� 5      "   6   .R�5   
     5      �� 5      "   6   .R�5   
   	  5      �� 5      "  
 6   .R�5   
     5      �� 5       "   6   .R�5!   
     5"      �� 5#      "   6   .R�5$   
     5%      �� 5&      "   6   .R�5'   
     5(      �� 5)      "   6   .R�5*   
     5+      �� 5,      "   6   .R�5-   
     5.      S� 51      $ 	GetValues��6.   "  6E    52   
   M� 53      $ model:TipoPaso��6   55      S� 56      $ 	GetValues��6.   "  6E    57   
   M� 58      $ model:TipoPeriodicidad��6   5:      S� 5;      $ 	GetValues��60   "  6G    5<   
   M� 5=      $ model:TipoOrigen��6   5?      �� 5A      " ��68    5B   
   P� 5C       �@=�HasError . . �5D      �� 	 �@�ToolTip
 6,   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5E      5G      �� 5H      " ��6@    5I   
   P� 5J       �@=�HasError . . �5K      �� 	 �@�ToolTip
 6,   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5L      5N      �� 5P      " ��6   .s�5Q   
   ��Ejecución Workflow��6)   ��5R   
   Ejecución Tarea EIM��6*   ��5S   
   Otro��6   5T      �� 5V      " ��6!   .s�5W   
   ��00��6   ��5X   
   01��6   ��5Y   
   02��6   ��5Z   
   03��6   ��5[   
   04��6   ��5\   
   05��6   ��5]   
   06��6   ��5^   
   07��6   ��5_   
   08��6   ��5`   
   09��6   ��5a   
   10��6   ��5b   
   11��6   ��5c   
   12��6   ��5d   
   13��6   ��5e   
   14��6   ��5f   
   15��6   ��5g   
   16��6   ��5h   
   17��6   ��5i   
   18��6   ��5j   
   19��6   ��5k   
   20��6   ��5l   
   21��6   ��5m   
   22��6   ��5n   
   23��6   5o      �� 5p      " ��6#   .s�5q   
   ��00��6   ��5r   
   01��6   ��5s   
   02��6   ��5t   
   03��6   ��5u   
   04��6   ��5v   
   05��6   ��5w   
   06��6   ��5x   
   07��6   ��5y   
   08��6   ��5z   
   09��6   ��5{   
   10��6   ��5|   
   11��6   ��5}   
   12��6   ��5~   
   13��6   ��5   
   14��6   ��5�   
   15��6   ��5�   
   16��6   ��5�   
   17��6   ��5�   
   18��6   ��5�   
   19��6   ��5�   
   20��6   ��5�   
   21��6   ��5�   
   22��6   ��5�   
   23��6   ��5�   
   24��6   ��5�   
   25��6   ��5�   
   26��6   ��5�   
   27��6   ��5�   
   28��6   ��5�   
   29��6   ��5�   
   30��6   ��5�   
   31��6   ��5�   
   32��6   ��5�   
   33��6   ��5�   
   34��6   ��5�   
   35��6   ��5�   
   36��6   ��5�   
   37��6   ��5�   
   38��6   ��5�   
   39��6   ��5�   
   40��6   ��5�   
   41��6   ��5�   
   42��6   ��5�   
   43��6   ��5�   
   44��6   ��5�   
   45��6   ��5�   
   46��6   ��5�   
   47��6   ��5�   
   48��6   ��5�   
   49��6   ��5�   
   50��6   ��5�   
   51��6   ��5�   
   52��6   ��5�   
   53��6   ��5�   
   54��6   ��5�   
   55��6   ��5�   
   56��6   ��5�   
   57��6   ��5�   
   58��6   ��5�   
   59��6   5�      5�      