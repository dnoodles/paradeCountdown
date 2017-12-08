<template>
  <div @click="$router.push({name: 'map'})">
    <div id="snow">
      <ul class="wire">
        <li style="over" v-for="x in Math.round(screenWidth / 50)" :key="x"></li>
      </ul>
      <div class="container">
        <h1 class="title">Smithtown Fire Department</h1>
        <router-view></router-view>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'app',
  computed: {
    screenWidth () {
      return window.screen.width
    }
  },
  mounted () {
    this.$router.push({name: 'christmasParadeCountdown'})
    document.addEventListener('touchmove', function (event) {
      if (event.scale !== 1) { event.preventDefault() }
    }, false)
  }
}
</script>

<style>

.wire{
  z-index: 1;
  text-align: center;
  white-space: nowrap;
  position: absolute;
  padding: 0;
  width: 100%;
  top: -100px;
  border-bottom: 3px solid #222;
  height: 100px;
}

.wire li{
  position: relative;
  list-style: none;
  margin: 0 15px;
  display: inline-block;
  width: 15px;
  height: 30px;
  border-radius: 50%;
  top: 102px;
  background: #fff;
  /*animation here*/
  -webkit-animation-name: even-flash;
          animation-name: even-flash;
  -webkit-animation-duration: 1s;
          animation-duration: 1s;
  -webkit-animation-iteration-count: infinite;
          animation-iteration-count: infinite;
  -webkit-animation-fill-mode: both;
          animation-fill-mode: both;
}

.wire li:nth-child(odd){
  -webkit-animation-name: odd-flash;
          animation-name: odd-flash;
}

.wire li::before{
  content: "";
  position: absolute;
  width: 14px;
  height: 10px;
  border-radius: 4px;
  top: -5px;
  left: 0;
  background: #444;
}
.title {
  margin-top:80px;
  -ms-flex-item-align: start;
      align-self: flex-start;
  -ms-flex-preferred-size: 100%;
      flex-basis: 100%;
}

h1 {
  color: rgba(252, 0, 0, 0.5882352941176471);
  text-transform: uppercase;
  text-align: center;
  font-size: 2.5rem;
  letter-spacing: .3rem;    
}

html {
  touch-action: none;
}

#snow{
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: horizontal;
  -webkit-box-direction: normal;
      -ms-flex-flow: row wrap;
          flex-flow: row wrap;
  -webkit-box-pack: center;
      -ms-flex-pack: center;
          justify-content: center;
  -webkit-box-align: stretch;
      -ms-flex-align: stretch;
          align-items: stretch;
	background: none;
	font-family: Androgyne;
	height: 100%;
	left: 0;
	position: absolute;
	top: 0;
	width: 100%;
	z-index:1;
	background-color:rgba(0, 15, 47, 0.9490196078431372); 
	background-image: url('assets/snow.png'), url('assets/snow2.png'), url('assets/snow3.png');
	-webkit-animation: snow 20s linear infinite;
	animation: snow 20s linear infinite;
}
@keyframes snow {
0% {background-position: 0px 0px, 0px 0px, 0px 0px;}
 100% {background-position: 500px 1000px, 400px 400px, 300px 300px;}
}

@-webkit-keyframes snow {
0% {background-position: 0px 0px, 0px 0px, 0px 0px;}
 100% {background-position: 500px 1000px, 400px 400px, 300px 300px;}
}

@-webkit-keyframes even-flash {
  0%, 100%{
    background: rgba(75, 255, 65, 0.9);
    -webkit-box-shadow: 0 2px 20px 4px rgba(53, 218, 34, 0.9098039215686274);
            box-shadow: 0 2px 20px 4px rgba(53, 218, 34, 0.9098039215686274)
  }
  50%{
    background: rgba(75, 255, 65, 0.9);
    -webkit-box-shadow: 0 2px 20px 4px rgba(76, 255, 65, 0.48);
            box-shadow: 0 2px 20px 4px rgba(76, 255, 65, 0.48);
  }
}

@keyframes even-flash {
  0%, 100%{
    background: rgba(75, 255, 65, 0.9);
    -webkit-box-shadow: 0 2px 20px 4px rgba(53, 218, 34, 0.9098039215686274);
            box-shadow: 0 2px 20px 4px rgba(53, 218, 34, 0.9098039215686274)
  }
  50%{
    background: rgba(75, 255, 65, 0.9);
    -webkit-box-shadow: 0 2px 20px 4px rgba(76, 255, 65, 0.48);
            box-shadow: 0 2px 20px 4px rgba(76, 255, 65, 0.48);
  }
}

@-webkit-keyframes odd-flash {
  50%{
    background: #e20c0b;
    -webkit-box-shadow: 0 2px 20px 4px #ff0000;
            box-shadow: 0 2px 20px 4px #ff0000; 
  }
  0%, 100%{
    background: #e20c0b;
    -webkit-box-shadow: 0 2px 20px 4px rgba(234, 21, 21, 0.3);
            box-shadow: 0 2px 20px 4px rgba(234, 21, 21, 0.3);
  }
}

@keyframes odd-flash {
  50%{
    background: #e20c0b;
    -webkit-box-shadow: 0 2px 20px 4px #ff0000;
            box-shadow: 0 2px 20px 4px #ff0000; 
  }
  0%, 100%{
    background: #e20c0b;
    -webkit-box-shadow: 0 2px 20px 4px rgba(234, 21, 21, 0.3);
            box-shadow: 0 2px 20px 4px rgba(234, 21, 21, 0.3);
  }
}
</style>
