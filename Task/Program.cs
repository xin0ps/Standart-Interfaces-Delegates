﻿using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using Task;

//1.DocumentProgram adinda bir class yaradin hansi ki icinde uc metod var:

//	-OpenDocument
//- EditDocument(virtual)
//    - SaveDocument(virtual)


//    Her uc metod voiddir ve ekrana acagidakilari cixardirlar.

//	1. Document Opened
//	2. Can Edit in Pro and Expert versions
//	3. Can Save in Pro and Expert versions

// 2. ProDocumentProgram adinda bir class yaradin hansi ki DocumentProgram classindan miras alir ve ekrana asagidakilari cixardir:

//	1.Document Opened
//    2.Document Edited(burda override elediyiniz metodu seald edirsiniz)

//    3.Document Saved in doc format, for pdf format buy Expert packet

//3. ExpertDocument adinda bir class yaradin hansi ki ProDocumentProgram classindan miras alir ve ekrana asagidakilari cixardir:

//	1.Document Opened
//    2.Document Edited
//    3.Document Saved in pdf format

//4. Program ise duse zaman userden acar daxil etmeyini isteyirsiniz. Acarlar basic, pro ve expert sozleridir. Qebul elediyiniz acara uygun olaraq muvafiq obyektleri yaradirsiniz:

//	basic = DocumentProgram

//    pro = ProDocumentProgram

//    expert = ExpertDocument

//ve OpenDocument, EditDocument, SaveDocument metodlarini cagirirsiniz;

//Qeyd: Qebul olunan acara gore yaradilan obyektler DocumentProgram classina upcast olunmalidir. Meselen asagidaki kimi

//	DocumentProgram docProgram = new ProDocumentProgram(); ve ya 
//	DocumentProgram docProgram = new ExpertDocument();


//Ugurlar...

start.Start();