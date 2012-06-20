jQuery(function(){
	$("#slider").chopSlider({
		/* Slide Element */
		slide : ".slide",
		/* Controlers */
		nextTrigger : "a#slide-next",
		prevTrigger : "a#slide-prev",
		hideTriggers : true,
		sliderPagination : ".slider-pagination",
		/* Captions */
		useCaptions : true,
		everyCaptionIn : ".sl-descr",
		showCaptionIn : ".caption",
		captionTransform : "scale(0) translate(-600px,0px) rotate(45deg)",
		/* Autoplay */
		autoplay : false,
		autoplayDelay : 6000,
		/* Default Parameters */
		t2D : csTransitions['vertical'][0],
		t3D : false,
		/* For Mobile Devices */
		mobile: csTransitions['mobile']['random'],
		/* For Old and IE Browsers */
		noCSS3:csTransitions['noCSS3']['random'],
		onStart: function(){ /* Do Something*/ },
		onEnd: function(){ /* Do Something*/ }
	})
	
	$(".vertical a").click(function(e){
		e.preventDefault();
		if($.chopSlider.isAnimating()) return;
		$(".active-transition").removeClass("active-transition")
		$(this).addClass("active-transition")
		$.chopSlider.redefine({  t2D : csTransitions['vertical'][$(this).index()], t3D : false  })	
	})
	$(".horizontal a").click(function(e){
		e.preventDefault();
		if($.chopSlider.isAnimating()) return;
		$(".active-transition").removeClass("active-transition")
		$(this).addClass("active-transition")
		$.chopSlider.redefine({  t2D : csTransitions['horizontal'][$(this).index()], t3D : false  })	
	})
	$(".multi a").click(function(e){
		e.preventDefault();
		if($.chopSlider.isAnimating()) return;
		$(".active-transition").removeClass("active-transition")
		$(this).addClass("active-transition")
		$.chopSlider.redefine({  t2D : csTransitions['multi'][$(this).index()], t3D : false  })	
	})
	$(".half a").click(function(e){
		e.preventDefault();
		if($.chopSlider.isAnimating()) return;
		$(".active-transition").removeClass("active-transition")
		$(this).addClass("active-transition")
		$.chopSlider.redefine({  t2D : csTransitions['half'][$(this).index()], t3D : false  })	
	})
	$(".sexy a").click(function(e){
		e.preventDefault();
		if($.chopSlider.isAnimating()) return;
		$(".active-transition").removeClass("active-transition")
		$(this).addClass("active-transition")
		$.chopSlider.redefine({  t2D : csTransitions['sexy'][$(this).index()], t3D : false  })	
	})
	$(".3DBlocks a").click(function(e){
		e.preventDefault();
		if($.chopSlider.isAnimating()) return;
		if(!$.chopSlider.has3D()) { 
			alert("Sorry! Your browser do not support 3D transitions");
			return
		}
		$(".active-transition").removeClass("active-transition")
		$(this).addClass("active-transition")
		$.chopSlider.redefine({  t2D : csTransitions['vertical'][0], t3D : csTransitions['3DBlocks'][$(this).index()]  })	
	})
	$(".3DFlips a").click(function(e){
		e.preventDefault();
		if($.chopSlider.isAnimating()) return;
		if(!$.chopSlider.has3D()) { 
			alert("Sorry! Your browser do not support 3D transitions");
			return
		}
		$(".active-transition").removeClass("active-transition")
		$(this).addClass("active-transition")
		$.chopSlider.redefine({  t2D : csTransitions['vertical'][0], t3D : csTransitions['3DFlips'][$(this).index()]  })	
	})
})

