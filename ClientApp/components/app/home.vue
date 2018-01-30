<template>
    <section id="index" class="parallax">
    <div class="index">
        <div class="text-center">
            <div class="clearfix"></div>
            <br />
            <div class="clearfix"></div>
            <br />
            <img src="../../images/HMT-Logo-outline.png" style="padding: 20px;" class="img-responsive center-block" />
            <div class="clearfix"></div>
            <br />
        </div>
        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8 text-center">
                <blockquote>
                    <carousel :autoplay='true' :perPage="1" :autoplayTimeout='20000'>
                        <slide>
                            <p>{{slide1.quote}}</p>
                            <small>{{slide1.author}}</small>
                        </slide>
                        <slide>
                            <p>{{slide2.quote}}</p>
                            <small>{{slide2.author}}</small>
                        </slide>
                        <slide>
                            <p>{{slide3.quote}}</p>
                            <small>{{slide3.author}}</small>
                        </slide>
                        <slide>
                            <p>{{slide4.quote}}</p>
                            <small>{{slide4.author}}</small>
                        </slide>
                    </carousel>
                </blockquote>
            </div>
            <div class="col-md-2"></div>
        </div>
        <bottom-nav></bottom-nav>
    </div>
</section>
</template>

<script>
    import { Carousel, Slide } from 'vue-carousel';
    import bottomNav from '../common/bottom-nav.vue'

    export default {
        name: 'home',
        components: {
            Carousel,
            Slide,
            bottomNav
        },
        data() {
            return {
                slide1: {
                    quote: "The stronger person is not the one making the most noise but the one who can quietly direct the conversation toward defining and solving problems.",
                    author: "Aaron T. Beck"
                },
                slide2: {
                    quote: "The best years of your life are the ones in which you decide your problems are your own. You do not blame them on your mother, the ecology, or the president. You realize that you control your own destiny.",
                    author: "Albert Ellis"
                },
                slide3: {
                    quote: "We can’t solve problems by using the same kind of thinking we used when we created them.",
                    author: "Albert Einstein"
                },
                slide4: {
                    quote: "The happiness of your life depends on the quality of your thoughts.",
                    author: "Marcus Aurelius"
                }
            }
        },
    }
</script>